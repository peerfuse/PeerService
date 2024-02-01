using P2PokerSingleton;

namespace P2PokerAPI.Configurations;

public static class ServerConfiguration
{
    public static IServiceCollection DBConfiguration(this IServiceCollection service)
        => service.ServerInfo();
    
    static IServiceCollection ServerInfo(this IServiceCollection service)
    {
        service.AddSingleton<Singleton>();
        return service;
    }
}