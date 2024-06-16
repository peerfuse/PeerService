using System.Text.Json;
using Configurations;
using Controllers;
using Microsoft.AspNetCore.Mvc;
using Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddUseCase();
builder.Services.AddAndConfigureControllers();
builder.Services.AddAndConfigureControllers()
    .AddUseCase()
    .DBConfiguration();

var app = builder.Build();
app.UseDocumentation();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.MapPost("/Login", ([FromBody] User user) =>
    {
        var u = new UserData("200", Guid.NewGuid(), user);
    Console.WriteLine(JsonSerializer.Serialize(user));
    return u;
})
    .WithName("Accounts")
    .WithOpenApi();

app.Run();

public partial class Program { }