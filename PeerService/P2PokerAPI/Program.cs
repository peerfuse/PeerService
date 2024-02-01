
using Microsoft.AspNetCore.Hosting;
using P2PokerAPI;
using System.Net;
using P2PokerAPI.Configurations;
using P2PokerAPI.Host;

var builder = WebApplication.CreateBuilder(args);
new Startup().StartHost();
builder.Services.AddAndConfigureControllers();
builder.Services.DBConfiguration();
var app = builder.Build();

app.UseDocumentation();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();

