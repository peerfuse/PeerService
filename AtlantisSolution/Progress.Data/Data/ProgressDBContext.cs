using Microsoft.EntityFrameworkCore;

namespace Progress.Data.Data;

public class ProgressDBContext : DbContext
{
    public ProgressDBContext(){}
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={Path.Combine("/db/", "ProgressDB.db")}");
}