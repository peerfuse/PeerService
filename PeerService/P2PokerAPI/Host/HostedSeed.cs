using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;
using P2PokerContext;
using P2PokerEntitys;
using P2PokerRepository;

namespace P2PokerAPI.Host;

public class HostedSeed  : IHostedService
{ TcpListener listener {get;set;}
    
    public async Task StartAsync(CancellationToken cancellationToken)
    {
        Server server = new Server(IPAddress.Any.ToString(), 7777);
        await Task.CompletedTask;
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
    }
}