using Data;
using Microsoft.AspNetCore.Mvc;
using Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
new InicializaBD().Initialize(new AtlantisData());
app.MapPost("/login", ([FromBody] User user) =>
{
    
});

app.MapGet("/status", () =>
{
    return $" Data Service in Running : {DateTime.Now}";
}).WithName("status").WithOpenApi();



app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int) (TemperatureC / 0.5556);
}