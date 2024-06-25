using System;
using System.Threading;
using System.Threading.Tasks;
using AtlantisLouncher.Core;

namespace AtlantisLouncher.Interfaces
{
    public interface IAtlantsRepository
    {
        Task Insert(UserData user, CancellationToken cancellationToken);
    }
}
