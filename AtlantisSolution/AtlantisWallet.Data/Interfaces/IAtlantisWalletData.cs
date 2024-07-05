namespace Interfaces;

public interface IAtlantisWalletData
{
    Task<object?> GetObjectWalletInfo(object _object, CancellationToken cancellationToken);
    Task<object> InsetObjectWalletInfo(object _object, CancellationToken cancellationToken);
    Task<object?> GetObjectWalletUser(object _object, CancellationToken cancellationToken);
    Task<object> InsetObjectWalletUser(object _object, CancellationToken cancellationToken);
    Task<object> UpdateObject(object _object, CancellationToken cancellationToken);
    Task RemoveObject(object _object, CancellationToken cancellationToken);
}