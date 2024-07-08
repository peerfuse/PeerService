using Models;

namespace Interfaces;

public interface IPeerNameResolverRepository
{
    void ResolvePeerName(string peerId);
    PeerEndPointsCollection _ipEndPointCollection { get; set; }
}