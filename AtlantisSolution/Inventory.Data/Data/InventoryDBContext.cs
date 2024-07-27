using Microsoft.EntityFrameworkCore;
using Models;

namespace Data;

public class InventoryDBContext : DbContext
{
    string Id { get; set; }
    public InventoryDBContext(string value)
        => Id = value;
    
    public DbSet<Item> _Items { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite($"Data Source={Path.Combine("/db/", $"{Id}.db")}");
    }
}