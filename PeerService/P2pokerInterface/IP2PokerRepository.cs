
using P2PokerBean;

namespace P2pokerInterface;

public interface IP2PokerRepository : IGenericRepository<Room>, ISearchableRepository<Room>
{

    public Task Update(
        Room _room
    );

    
}