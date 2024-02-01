using System.Reflection;
using P2PokerBean;
using P2PokerEnums;

namespace P2pokerInterface;

public interface IControllerManager
{
    public void HandleRequest(RequestCode requestCode, ActionCode actionCode, string data, IPlayer client);
}