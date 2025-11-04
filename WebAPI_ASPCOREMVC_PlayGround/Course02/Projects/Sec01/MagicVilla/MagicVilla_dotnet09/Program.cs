var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

//#in .net 9.0 by default API documentation with '.net openapi'
//builder.Services.AddOpenApi();

//#Add Swagger instead
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //#default .net 09 OpenApi
    //app.MapOpenApi();

    //#use swagger and UI instead
    app.UseSwagger();
    app.UseSwaggerUI();
    //#another swagger UI options
    /*
     app.UseSwaggerUI(options => {
       options.SwaggerEndpoint("/swagger", "VillaAPI_Swagger");
    });
    */
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
