using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AtlantisLouncher.Core;
using Microsoft.EntityFrameworkCore;

namespace AtlantisLouncher.Data
{
    public class AtlantsDbConfigurations : IEntityTypeConfiguration<UserData>
    {
        public void Configure(EntityTypeBuilder<UserData> builder)
        {
            builder.HasKey(x => x.uid);
        }
    }
}
