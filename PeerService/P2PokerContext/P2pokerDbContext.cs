using System.Net.Sockets;
using Microsoft.EntityFrameworkCore;
using P2PokerBean;
using P2PokerExceptions;

namespace P2PokerContext;

public class P2pokerDbContext : DbContext
{
    public Dictionary<Guid, Room> _rooms = new Dictionary<Guid, Room>();
}