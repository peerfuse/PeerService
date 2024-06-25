using Microsoft.EntityFrameworkCore;
using AtlantisLouncher.Core;
using JetBrains.Annotations;

namespace AtlantisLouncher.Data
{
    public class AtlantsDbContext : DbContext
    {
        public DbSet<UserData> _users => Set<UserData>();

        public AtlantsDbContext(DbContextOptions<AtlantsDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        => modelBuilder.ApplyConfiguration(new AtlantsDbConfigurations());

            
    }
}

