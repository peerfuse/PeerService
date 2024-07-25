using Atlantis.Chat.Enums;

namespace Atlantis.Chat.Core;

[Serializable]
public class Msg
{
    public Msg(){}
    public string UserId { get; set; }
    public RequestCode requestCode { get; set; }
    public ActionCode actionCode { get; set; }
    public string destinatary { get; set; }
    public string _string { get; set; }

    public Msg(string UserId, RequestCode requestCode, ActionCode actionCode, string destinatary, string _string)
    {
        this.UserId = UserId;
        this.requestCode = requestCode;
        this.actionCode = actionCode;
        this.destinatary = destinatary;
        this._string = _string;
    }
}