using Data;
using Interfaces;

namespace Repository;

public class AtlantisRepository : IAtlantisData
{
    public InventoryDBContext _AtlantisData { get; set; }

    public AtlantisRepository(InventoryDBContext _context)
        => _AtlantisData = _context;
    public Task<object?> GetObject(object _object, CancellationToken cancellationToken)
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