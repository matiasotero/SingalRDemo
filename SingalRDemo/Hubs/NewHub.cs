using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SingalRDemo.Hubs
{
    public class NewHub : Hub
    {
        public async Task Send(string user, string message)
        {
            await Clients.All.SendAsync("Send", user, message);
        }

        public async Task DragView(float rawX, float initX, float rawY, float intiY)
        {
            await Clients.Others.SendAsync("DragView", rawX, initX, rawX, initX);
        }
    }
}