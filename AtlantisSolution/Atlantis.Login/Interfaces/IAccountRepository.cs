namespace Interfaces;

public interface IAccountRepository
{
    Task<object> GetObject(object _object, CancellationToken cancellationToken);
}