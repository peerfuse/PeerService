using Atlantis.Chat.Enums;
using Atlantis.Chat.Interfaces;

namespace Atlantis.Chat.Core;

public class ControllerManager
{
    public ControllerManager(){}

    public void HandleRequest(Server server, RequestCode _requestCode, ActionCode _actionCode, Msg msg, Client pl)
    {
        new MesageController().Action(server,_actionCode, msg, pl);
    }
}