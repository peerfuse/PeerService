using Data;

namespace Interfaces;

public interface INetworkRepository
{
    NetworkData _networkData { get; set; }
    
    Task<object?> GetNodeObject(byte[] _object, CancellationToken cancellationToken);
    Task<object?> GetContractObject(byte[] _object, CancellationToken cancellationToken);
    Task<object> InsetNodeObject(object _object, CancellationToken cancellationToken);
    Task<object> InsetContractObject(object _object, CancellationToken cancellationToken);
}