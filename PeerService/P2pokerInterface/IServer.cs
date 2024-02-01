using System.Net.Sockets;
using P2PokerEnums;

namespace P2pokerInterface;

public interface IServer
{
    void HandleRequest(RequestCode requestCode, ActionCode actionCode, string data, IPlayer client);
    void RemoveClient(IPlayer player, Socket socket);
}