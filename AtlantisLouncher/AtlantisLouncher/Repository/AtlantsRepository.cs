using System;
using System.Threading;
using System.Threading.Tasks;
using AtlantisLouncher.Core;
using AtlantisLouncher.Data;
using AtlantisLouncher.Interfaces;

namespace AtlantisLouncher.Repository
{
    public class AtlantsRepository : IAtlantsRepository
    {
        AtlantsDbContext _atlantsDb { get; set; }

        public AtlantsRepository(AtlantsDbContext dbContext)
            => _atlantsDb = dbContext;

        public async Task Insert(UserData user, CancellationToken cancellationToken)
        {
            await _atlantsDb._users.AddRangeAsync(user);
            await _atlantsDb.SaveChangesAsync(cancellationToken);
            await Task.CompletedTask;
        }
    }
}
