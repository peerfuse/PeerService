using Data;
using Models;
using Microsoft.AspNetCore.Mvc;
using Progress.Data.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
new InicializaBD().Initialize(new ItemsDBContext());
app.MapGet("/Item/{Id}", async (string itemID) =>
{
    Console.WriteLine(itemID);
    var rp = await GetItem(itemID);
    return rp;
});

async Task<Item> GetItem(string itemId)
{
    var db = new ItemsDBContext();
    var rp = new AtlantisRepository(db);
    var ac = await rp.GetObject(itemId, CancellationToken.None) as Item;
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
    return $" Item.Data Service in Running : {DateTime.Now}";
})
    .WithName("status")
    .WithOpenApi();
app.Run();