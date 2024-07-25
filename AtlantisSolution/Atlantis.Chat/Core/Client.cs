using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using Atlantis.Chat.Dao;
using Atlantis.Chat.Enums;
using Atlantis.Chat.Interfaces;

namespace Atlantis.Chat.Core;

public class Client : ClientDao, IPlayer
{
    public Client(){}

    public string? UserID { get; set; }
    public WebSocket? socket { get; set; }
    public async void SendMessage(Msg msg)
    {
        string message = JsonSerializer.Serialize(msg);
        var buffer = Encoding.UTF8.GetBytes(message);
        await socket!.SendAsync(new ArraySegment<byte>(buffer), WebSocketMessageType.Text, true, CancellationToken.None);
    }

    public void Remove(IPlayer player)
    {
        
    }

    public void OnProcessMessage(RequestCode _requestCode, ActionCode _actionCode, Msg msg)
        => new Server().HandleRequest(_requestCode, _actionCode, msg, this);

    public async Task OnStart(Server server, HttpContext context, WebSocket? webSocket)
    {
        server._players.Add(this);
        socket = webSocket;
        var buffer = new byte[1024 * 4];
        while (webSocket!.State == WebSocketState.Open && !talk)
        {
            WebSocketReceiveResult result = await socket!.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
            new Message().ReadMessage(Encoding.UTF8.GetString(buffer, 0, result.Count), OnProcessMessage);
        }
        
    }
}