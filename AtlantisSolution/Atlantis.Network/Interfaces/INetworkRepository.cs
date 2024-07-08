using Data;

namespace Interfaces;

public interface INetworkRepository
{
    NetworkData _networkData { get; set; }
    
    Task<object?> GetNodeObject(byte[] _object, CancellationToken cancellationToken);
    Task<object> InsetNodeObject(object _object, CancellationToken cancellationToken);
    Task<object> UpdateNodeObject(object _object, CancellationToken cancellationToken);
}