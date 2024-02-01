using P2PokerEnums;

namespace P2PokerBean;

[Serializable]
public class Msg
{
    public RequestCode requestCode { get; set; }
    public ActionCode actionCode { get; set; }
    public string _string { get; set; }

    public Msg(RequestCode requestCode, ActionCode actionCode, string @string)
    {
        this.requestCode = requestCode;
        this.actionCode = actionCode;
        _string = @string;
    }
}