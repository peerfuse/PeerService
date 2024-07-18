using Microsoft.EntityFrameworkCore;

namespace Data;

public class InventoryDBContext : DbContext
{
    string Id { get; set; }
    public InventoryDBContext(string value)
        => Id = value;
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={Path.Combine("/db/", $"InventoryDB-{Id}.db")}");
}