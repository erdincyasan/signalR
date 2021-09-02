using ChatAppWithSignalR.Context;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatAppWithSignalR.Hubs
{

    public class ChatHub : Hub
    {
        private readonly ChatContext _context;
        public ChatHub(ChatContext context)
        {
            _context = context;
        }
        public async Task SendMessage(string userName, string message)
        {
            _context.messages.Add(new Entities.Message
            {
                MessageContent=message,
                SenderName=userName
            });
            await _context.SaveChangesAsync();

            await Clients.All.SendAsync("ReceiveMessage", userName, message);
        }
    }
}
