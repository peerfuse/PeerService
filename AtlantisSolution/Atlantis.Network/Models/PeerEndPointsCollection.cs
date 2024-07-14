using System.Collections.ObjectModel;

namespace Models;

public class PeerEndPointsCollection
{
    public PeerEndPointsCollection(Guid UserId)
    {
        this.peerName = UserId;
        this.peerEndPointInfos = new ObservableCollection<ICollection<Guid>>();
    }

    public Guid peerName { get; set; }
    public ObservableCollection<ICollection<Guid>> peerEndPointInfos { get;  }
}