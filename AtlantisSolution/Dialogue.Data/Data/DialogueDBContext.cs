using Microsoft.EntityFrameworkCore;

namespace Data;

public class DialogueDBContext : DbContext
{
    public DialogueDBContext(){}
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={Path.Combine("/db/", "DialogueDB.db")}");
}