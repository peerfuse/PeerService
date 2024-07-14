using Contracts;
using Data;
using Interfaces;
using Models;

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
    
    public async Task<object?> GetContractObject(byte[] _object, CancellationToken cancellationToken)
    {
        var obj = _networkData._Contracts.FirstOrDefault(n => n.hash == _object);
        await _networkData.SaveChangesAsync(cancellationToken);
        return obj;
    }

    public async Task<object> InsetNodeObject(object _object, CancellationToken cancellationToken)
    {
        var node = _object as Node;
        _networkData._nodes.Add(node);
        await _networkData.SaveChangesAsync(cancellationToken);
        var obj = _networkData._nodes.FirstOrDefault(x => x.hash == node.hash);
        return obj;
    }
    
    public async Task<object> InsetContractObject(object _object, CancellationToken cancellationToken)
    {
        var contract = _object as Contract;
        _networkData._Contracts.Add(contract);
        await _networkData.SaveChangesAsync(cancellationToken);
        var obj = _networkData._Contracts.FirstOrDefault(x => x.hash == contract.hash);
        return obj;
    }
}