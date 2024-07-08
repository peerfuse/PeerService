using Models;

namespace Interfaces;

public interface IPeerConfigurationService<T>
{
    Guid Id { get; set; }
        
    Peer<IPingService> peer { get; set; }
        
    T PingService { get; set; }
        
    bool StartPeerService();

    bool StopPeerService();
}