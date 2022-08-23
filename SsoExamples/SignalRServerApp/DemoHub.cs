using Microsoft.AspNetCore.SignalR;

namespace SignalRServerApp;

public class DemoHub : Hub
{
    public async Task BroadcastMessage(string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", message);
    }
}
