namespace Models;

public class PeerEndPointInfo<T>
{
    public string peerUrl { get; set; }
        
    public ICollection<T> ipEndPointCollection { get; set; }
        
    public DateTime lastUpdate { get; set; }
        
        
}