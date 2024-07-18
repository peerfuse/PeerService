using Microsoft.EntityFrameworkCore;

namespace Data;

public class EventDBContext : DbContext
{
    public EventDBContext(){}
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={Path.Combine("/db/", "EventDB.db")}");
}