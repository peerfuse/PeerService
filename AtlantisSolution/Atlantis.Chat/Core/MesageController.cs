using Atlantis.Chat.Enums;
using Atlantis.Chat.Interfaces;

namespace Atlantis.Chat.Core;

public class MesageController
{
    public MesageController(){}
    Server _server { get; set; }
    Client _client { get; set; }

    public void Action(Server server, ActionCode actionCode, Msg msg, Client pl)
    {
        _server = server;
        _client = pl;
        if (actionCode == ActionCode.UserId)OnUserId(msg);
        if (actionCode == ActionCode.Mesage) OnMessage(msg);
    }

    private void OnUserId(Msg msg)
    {
        _client.UserID = msg.UserId;
        _client.talk = !_client.talk;
    }

    private void OnMessage(Msg msg)
        => _client.SendMessage(msg);
}