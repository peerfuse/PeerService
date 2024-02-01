using System.Net;
using P2PokerAPI.Host;
using P2PokerEntitys;

namespace P2PokerAPI;

public class Startup
{
    public Startup(){}
    public void StartHost()
    {
            
        new HostBuilder().ConfigureServices((hostBuilderContext, services) =>
        {
            Server server = new Server(IPAddress.Any.ToString(), 7777);
            services.AddHostedService<HostedSeed>();
        }).RunConsoleAsync();
    }
    
}