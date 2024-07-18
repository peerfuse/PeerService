using Microsoft.EntityFrameworkCore;

namespace Data;

public class FriendDBContext : DbContext
{
    string Id { get; set; }

    public FriendDBContext(string value)
        => Id = value;
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={Path.Combine("/db/", $"FriendDB-{Id}.db")}");
}