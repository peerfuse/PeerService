using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using P2pokerInterface;

namespace P2PokerDAO
{
    public class ClientDAO
    {
        public IServer server { get; set; }
        public int coins = 0;
        public Guid UUID { get; set; }
        public Socket client { get; set; }
        public static ManualResetEvent? connectDone, receiveDone;
        public static IControllerManager? controllerManager;
        public IRoomController roomController { get; set; }
        public String response = String.Empty;
        public int PlayerNumber { get; set; }
        public byte[] buffer = new byte[1024];

        public void SetBuffer(byte[] buffer) => this.buffer = buffer;
        public void SetSocket(Socket socket) => this.client = socket;
        
        public void SendMessage(byte[] bytes)
        {
        }

        //public void OnBetRoom(string[] info) => roomController.OnPot(UUID, info);
    }
}
