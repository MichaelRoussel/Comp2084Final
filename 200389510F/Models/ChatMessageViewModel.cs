using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _200389510F.Models
{
    public class ChatMessageViewModel
    {
        public ChatMessage newMessage { get; set; }
        public IEnumerable<ChatMessage> Messages { get; set; }
    }
}