using System;
using AtlantisLouncher.Data;
using AtlantisLouncher.Interfaces;

namespace AtlantisLouncher.Repository
{
    public class AtlantsRepository : IAtlantsRepository
    {
        AtlantsDbContext _cursedStoneDb;

        public AtlantsRepository(AtlantsDbContext dbContext)
            => _cursedStoneDb = dbContext;
    }
}
