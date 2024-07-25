using Microsoft.EntityFrameworkCore;
using Models;

namespace Data;

public class AtlantisData : DbContext
{
    public DbSet<Account> _Accounts { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={Path.Combine("/db/", "AtlantisData.db")}");
}