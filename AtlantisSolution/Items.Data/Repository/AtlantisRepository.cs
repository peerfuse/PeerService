using Data;
using Interfaces;

namespace Progress.Data.Repository;

public class AtlantisRepository : IAtlantisData
{
    public ItemsDBContext _AtlantisData { get; set; }

    public AtlantisRepository(ItemsDBContext _context)
        => _AtlantisData = _context;
    public Task<object?> GetObject(string itemID, CancellationToken cancellationToken)
    {
        return null;
    }

    public Task<object> InsetObject(object _object, CancellationToken cancellationToken)
    {
        return null;
    }

    public Task<object> UpdateObject(object _object, CancellationToken cancellationToken)
    {
        return null;
    }

    public Task RemoveObject(object _object, CancellationToken cancellationToken)
    {
        return null;
    }
}