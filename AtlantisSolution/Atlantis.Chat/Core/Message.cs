using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Atlantis.Chat.Enums;

namespace Atlantis.Chat.Core;

public class Message
{
    public Message(){}

    public void ReadMessage(string _string, Action<RequestCode, ActionCode, Msg>OnProcessMessage)
    {
        var obj = DeserializeFromString(_string) as Msg;
        if (obj is null) Console.WriteLine(string.Format("{0} >>> {1}",DateTime.Now , _string));
        if (obj is not null) OnProcessMessage(obj.requestCode, obj.actionCode, obj);
    }

    Msg? DeserializeFromString(string s)
    => JsonSerializer.Deserialize<Msg>(s);
}