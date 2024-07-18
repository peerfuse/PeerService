using Microsoft.EntityFrameworkCore;

namespace Data;

public class PerfilDBContext : DbContext
{
    public PerfilDBContext(){}
    
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={Path.Combine("/db/", "PerfilDB.db")}");
}