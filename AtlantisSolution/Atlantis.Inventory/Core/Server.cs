using Enums;

namespace Core;

public class Server
{

    public Server(){}
    
    public List<Client> _players = new List<Client>();

    public void SetPlayer(Client? client)
    {
        if (client is not null) _players.Add(client);
    }
}