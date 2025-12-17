using MagicVillaAPI.CustomLogging;
using MagicVillaAPI.Data;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);
/*
//#config SeriLog instead the default Log
Log.Logger = new LoggerConfiguration().MinimumLevel.Debug()
    .WriteTo.File("serilog/VillaAPILogs.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();
//#from ConfigureHostBuilder apply serilog as logging provider
builder.Host.UseSerilog();
*/
//############################################################

//# Instead of 'public void ConfigureServices(IServiceCollection services)'

//add EF core DB context with sqlserver
builder.Services.AddDbContext<ApplicationDBContext>(option => {
    option.UseSqlServer(builder.Configuration.GetConnectionString("VillaAPIDB"));
});

// Add services to the container.
builder.Services.AddControllers(options =>
{
    //#by default false , return only what available format with no HTTP 406 error 'not acceptable'
    //#return HTTP 406 error  if no other format available like "accept:application/XML, HTML ..etc"
    options.ReturnHttpNotAcceptable = true;
})
                //#Enable API return  json serialization
                .AddNewtonsoftJson()
                //#reurn JSON data as XML formate "accept:application/XML"
                .AddXmlDataContractSerializerFormatters(); 

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

//#config dependency injection for custom logging
builder.Services.AddSingleton<ILogging, Logging>();

//############################################################

//#instead of 'public void Configure(IApplicationBuilder app, IWebHostEnvironment env)'
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

//#redirct http to https
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
