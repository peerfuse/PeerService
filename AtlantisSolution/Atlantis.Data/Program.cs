using System.Text.Json;
using Atlantis.Data.Repository;
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
app.MapGet("/login/{mail}", async (string mail) =>
{
    Console.WriteLine(mail);
    var rp = await GetAccount(new User(mail, ""));
    return rp;
});

async Task<Account> GetAccount(User user)
{
    var db = new AtlantisData();
    var rp = new AtlantisRepository(db);
    var ac = await rp.GetObject(user, CancellationToken.None) as Account;
    if (ac != null)
    {
        return ac;
    }
    else
    {
        return null;
    }
}

app.MapPost("/Register", async ([FromBody] User user) =>
{
    Console.WriteLine(JsonSerializer.Serialize(user));
    var rp = await RegisterAccount(new Account(Guid.NewGuid().ToString().Substring(0, 13), user.mail, user.password));
    return rp;
});

async Task<Account> RegisterAccount(Account _account)
{
    var db = new AtlantisData();
    var rp = new AtlantisRepository(db);
    var ac = await rp.InsetObject(_account, CancellationToken.None) as Account;
    if (ac != null)
    {
        return ac;
    }
    else
    {
        return null;
    }
}

app.MapGet("/status", () =>
{
    return $" Data Service in Running : {DateTime.Now}";
}).WithName("status").WithOpenApi();



app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int) (TemperatureC / 0.5556);
}