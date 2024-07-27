using Core;
using Microsoft.AspNetCore.Builder;
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

        app.UseRouting();

        app.UseWebSockets();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapGet("/", async context =>
            {
                /*
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
                */
            });
            
            endpoints.MapGet("/status", () =>
            {
                return $"Atlantis Inventory System Is Running ... ! {DateTime.Now}";
            });
            
            endpoints.MapPost("/Inventory", async ([FromBody] object msg) =>
            {
                return "200";

            });
        });
    }
}