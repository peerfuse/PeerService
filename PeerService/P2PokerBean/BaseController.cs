using P2PokerEnums;
using P2pokerInterface;

namespace P2PokerBean;

public abstract class BaseController
{
    protected RequestCode requestCode = RequestCode.None;

    public RequestCode RequestCode
    =>requestCode;
}