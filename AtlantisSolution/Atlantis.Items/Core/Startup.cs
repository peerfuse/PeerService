using System.Net.WebSockets;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Core;

public class Startup
{
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
                if (context.WebSockets.IsWebSocketRequest)
                {
                    var webSocket = await context.WebSockets.AcceptWebSocketAsync();
                    await Echo(context, webSocket);
                }
                else
                {
                    context.Response.StatusCode = 400;
                }
            });
            
            endpoints.MapGet("/GetItem/{itemID}", async (string itemID) =>
            {
                
            });
            
            endpoints.MapPost("/Item", async ([FromBody] Item _item) =>
            {
                
            });
            
            endpoints.MapPost("/ItemCategory/", async ([FromBody] ItemCategory _itemCategory) =>
            {
                
            });
            
            endpoints.MapGet("/status", () =>
            {

                return $"Atlantis Items Is Running ... ! {DateTime.Now}";
            });
            
            endpoints.MapGet("/Item", () =>
            {
                return "";
            });
        });
    }

    private async Task Echo(HttpContext context, WebSocket webSocket)
    {
        var buffer = new byte[1024 * 4];
        WebSocketReceiveResult result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
        while (!result.CloseStatus.HasValue)
        {
            var message = Encoding.UTF8.GetString(buffer, 0, result.Count);
            Console.WriteLine($"Received message: {message}");
            await webSocket.SendAsync(new ArraySegment<byte>(buffer, 0, result.Count), result.MessageType, result.EndOfMessage, CancellationToken.None);
            result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
        }
        await webSocket.CloseAsync(result.CloseStatus.Value, result.CloseStatusDescription, CancellationToken.None);
    }
}