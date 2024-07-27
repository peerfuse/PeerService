using Models;
using Microsoft.EntityFrameworkCore;

namespace Data;

public class CharacterDBContext : DbContext
{
    string Id { get; set; }
    public CharacterDBContext(string value)
        => Id = value;
    
    public DbSet<Character> _Characters { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite($"Data Source={Path.Combine("/db/", $"{Id}.db")}");
    }
}