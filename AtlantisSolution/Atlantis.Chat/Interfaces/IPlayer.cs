using System.Net.WebSockets;
using Atlantis.Chat.Core;
using Atlantis.Chat.Enums;

namespace Atlantis.Chat.Interfaces;

public interface IPlayer
{
    string? UserID { get; set; }
    WebSocket? socket { get; set; }
    void SendMessage(Msg msg);
    void Remove(IPlayer player);
    void OnProcessMessage(RequestCode _requestCode, ActionCode _actionCode, Msg msg);
    Task OnStart(Server server,HttpContext context, WebSocket webSocket);
}