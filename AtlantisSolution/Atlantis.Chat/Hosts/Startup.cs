using System.Net.WebSockets;
using System.Text;
using Atlantis.Chat.Core;
using Atlantis.Chat.Enums;
using Atlantis.Chat.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Hosts;

public class Startup
{
    Server server = new Server();
    public void ConfigureServices(IServiceCollection services)
    {
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        
        var summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        app.UseRouting();

        app.UseWebSockets();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapGet("/", async context =>
            {
                if (context.WebSockets.IsWebSocketRequest)
                {
                    var webSocket = await context.WebSockets.AcceptWebSocketAsync();
                    var userId = Guid.NewGuid().ToString();
                    Console.WriteLine($"User connected >> {userId}");
                    var p = new Client();
                    await p.OnStart(server,context, webSocket);
                    server.SetPlayer(p);
                }
                else
                {
                    context.Response.StatusCode = 400;
                }
            });
            
            endpoints.MapGet("/status", () =>
            {
                return $"Atlantis Chat System Is Running ... ! {DateTime.Now}";
            });
            
            endpoints.MapGet("/service", () =>
            {
                return "200";
            });
            
            endpoints.MapPost("/Mesage", ([FromBody] Msg msg) =>
            {
                server!.OnMesage(msg);
                
            });
        });
    }
}