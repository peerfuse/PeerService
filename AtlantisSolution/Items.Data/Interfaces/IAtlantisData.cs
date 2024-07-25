namespace Interfaces;

public interface IAtlantisData
{
    Task<object?> GetObject(string itemID, CancellationToken cancellationToken);
    Task<object> InsetObject(object _object, CancellationToken cancellationToken);
    Task<object> UpdateObject(object _object, CancellationToken cancellationToken);
    Task RemoveObject(object _object, CancellationToken cancellationToken);
}