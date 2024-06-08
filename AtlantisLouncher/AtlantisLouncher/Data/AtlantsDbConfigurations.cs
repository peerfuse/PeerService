using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AtlantisLouncher.Core;
using Microsoft.EntityFrameworkCore;

namespace AtlantisLouncher.Data
{
    public class AtlantsDbConfigurations : IEntityTypeConfiguration<User>
    {
        public AtlantsDbConfigurations() { }

        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.UserId);
        }
    }
}
