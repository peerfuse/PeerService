using Microsoft.EntityFrameworkCore;
using AtlantisLouncher.Core;

namespace AtlantisLouncher.Data
{
    public class AtlantsDbContext : DbContext
    {
        public DbSet<User> _users { get; set; }

        public AtlantsDbContext(DbContextOptions<AtlantsDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.ApplyConfiguration(new AtlantsDbConfigurations());
    }
}
