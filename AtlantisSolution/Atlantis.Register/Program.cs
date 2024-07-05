using System.Text.Json;
using Microsoft.AspNetCore.Builder;
using Models;
using Microsoft.AspNetCore.Mvc;
using Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapPost("/register", async ([FromBody] User user) =>
{
    Console.WriteLine(JsonSerializer.Serialize(user));
    var rp = await RegisterAccount(user);
    if (rp != null)
    {
        return rp;
    }
    else
    {
        return null;
    }
    
});

async Task<Account> RegisterAccount(User user)
{
    var rp = new AccountRepository();
    var ac = await rp.SendObject(user, CancellationToken.None) as Account;
    return ac;
}

app.MapGet("/status", () =>
{
    return $" Register Service in Running : {DateTime.Now}";
});

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
    {
        var forecast = Enumerable.Range(1, 5).Select(index =>
                new WeatherForecast
                (
                    DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    Random.Shared.Next(-20, 55),
                    summaries[Random.Shared.Next(summaries.Length)]
                ))
            .ToArray();
        return forecast;
    })
    .WithName("GetWeatherForecast")
    .WithOpenApi();

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int) (TemperatureC / 0.5556);
}