using P2PokerCore;

namespace P2pokerInterface;

public interface ISearchableRepository<Taggregate>
{
    Task<Taggregate> Search(
        Guid input
    );
}