namespace Interfaces;

public interface IAccountRepository
{
    Task<object> SendObject(object _object, CancellationToken cancellationToken);
}