using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatAppWithSignalR.Entities
{
    public class Message
    {
        public int MessageId { get; set; }
        public string SenderName { get; set; }
        public string MessageContent { get; set; }
    }
}
