using Atlantis.Chat.Enums;
using Atlantis.Chat.Interfaces;

namespace Atlantis.Chat.Core;

public class Server
{

    public Server(){}
    
    public List<Client> _players = new List<Client>();

    public void SetPlayer(Client? client)
    {
        if (client is not null) _players.Add(client);
    }

    public void OnMesage(Msg msg)
    => new ControllerManager().HandleRequest(this,msg.requestCode, msg.actionCode, msg, _players.Find(x => x!.UserID == msg.destinatary)!);

    public void HandleRequest(RequestCode requestCode, ActionCode actionCode, Msg msg, Client client)
    => new ControllerManager().HandleRequest(this,msg.requestCode, msg.actionCode, msg, client);
}