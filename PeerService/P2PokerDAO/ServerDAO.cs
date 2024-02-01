using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using P2PokerEnums;
using P2pokerInterface;

namespace P2PokerDAO
{
    public class ServerDAO
    {
        public IPAddress ipAddress;
        public IPEndPoint ipEndPoint;
        public Socket socket;
        public IControllerManager controllerManager;
        public static ManualResetEvent connectDone, receiveDone;
        public List<RoomControllerDAO> roomControllers = new List<RoomControllerDAO>();
        public Dictionary<Guid,IPlayer> clientList = new Dictionary<Guid, IPlayer>();
        public byte[] buffer = new byte[1024];
    }
}
