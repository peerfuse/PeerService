using Data;
using Interfaces;

namespace Repositorys;

public class NetworkRepository : INetworkRepository
{
    public NetworkRepository(){}
    public NetworkData _networkData { get; set; }
    public NetworkRepository(NetworkData networkData)
        => _networkData = networkData;
    public async Task<object?> GetNodeObject(byte[] _object, CancellationToken cancellationToken)
    {
        var obj = _networkData._nodes.FirstOrDefault(n => n.previushash == _object);
        await _networkData.SaveChangesAsync(cancellationToken);
        return obj;
    }

    public Task<object> InsetNodeObject(object _object, CancellationToken cancellationToken)
    {
        return null;
    }

    public Task<object> UpdateNodeObject(object _object, CancellationToken cancellationToken)
    {
        return null;
    }

    
    
    
    

}