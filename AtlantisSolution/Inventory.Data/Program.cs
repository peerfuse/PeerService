var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
//new InicializaBD().Initialize(new InventoryDBContext(Guid.NewGuid().ToString()));

app.MapGet("/status", () =>
    {
        return $" Inventory.Data Service in Running : {DateTime.Now}";
    })
    .WithName("status")
    .WithOpenApi();
app.Run();