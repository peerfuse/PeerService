using Microsoft.EntityFrameworkCore;
using Models;

namespace Atlantis.Data.Data;

public class AtlantisWalletData : DbContext
{
    public AtlantisWalletData(){}
    public DbSet<WalletUser> _WalletUsers { get; set; }
    public DbSet<WalletInfo> _WalletsInfo { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=AtlantisWalletData.db");
}