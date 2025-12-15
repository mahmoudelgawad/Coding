using Serilog;

var builder = WebApplication.CreateBuilder(args);

//#config SeriLog instead the default
Log.Logger = new LoggerConfiguration().MinimumLevel.Debug()
    .WriteTo.File("log/VillaAPILogs.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();
//#apply serilog to the middleware
builder.Host.UseSerilog();


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

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
