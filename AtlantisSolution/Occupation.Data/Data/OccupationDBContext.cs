using Microsoft.EntityFrameworkCore;

namespace Data;

public class OccupationDBContext : DbContext
{
    public OccupationDBContext(){}
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={Path.Combine("/db/", "OccupationDB.db")}");
}