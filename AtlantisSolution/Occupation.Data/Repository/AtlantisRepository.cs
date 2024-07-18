using Interfaces;

namespace Progress.Data.Repository;

public class AtlantisRepository : IAtlantisData
{
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