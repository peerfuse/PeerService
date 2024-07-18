using Microsoft.EntityFrameworkCore;

namespace Data;

public class ConquestDBContext : DbContext
{
    public ConquestDBContext(){}
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={Path.Combine("/db/", "ConquestDB.db")}");
}