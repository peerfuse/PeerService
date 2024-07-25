using Models;
using Microsoft.EntityFrameworkCore;

namespace Data;

public class ItemsDBContext : DbContext
{
    public DbSet<Item> _Items { get; set; }
    public DbSet<ItemCategory> _ItemCategories { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={Path.Combine("/db/", "ItemsDB.db")}");
}