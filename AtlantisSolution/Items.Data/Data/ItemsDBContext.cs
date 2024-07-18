using Microsoft.EntityFrameworkCore;

namespace Data;

public class ItemsDBContext : DbContext
{
    public ItemsDBContext(){}
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={Path.Combine("/db/", "ItemsDB.db")}");
}