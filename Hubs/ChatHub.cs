using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
namespace SignalRDeneme.Hubs
{
    public class ChatHub : Hub
    {
        public async Task MesajGonder(string userName, string message)
        {
            await Clients.All.SendAsync("MesajAl", userName, message);
        }
    }
}
