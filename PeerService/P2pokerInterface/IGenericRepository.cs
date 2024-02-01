using P2PokerBean;
using P2PokerCore;

namespace P2pokerInterface;

public interface IGenericRepository<TAggregate> : IRepository
{
    public Task Insert( TAggregate tAggregate);
    public Room Get(Guid Id);
    
    public Task Delete(Guid Id);
    
    public Task Update(Room _room);
    
}