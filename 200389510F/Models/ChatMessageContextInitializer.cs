using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _200389510F.Models
{
    public class ChatMessageContextInitializer : DropCreateDatabaseAlways<ChatMessageContext>
    {
        protected override void Seed(ChatMessageContext context)
        {
            context.ChatMessages.Add(new ChatMessage
            {
                Name = "Michael",
                Message = "Test Message 1",
                Date = DateTime.Now
            });
            context.ChatMessages.Add(new ChatMessage
            {
                Name = "Brandon",
                Message = "Test Message 2",
                Date = DateTime.Now
            });
            context.ChatMessages.Add(new ChatMessage
            {
                Name = "Simon",
                Message = "Test Message 3",
                Date = DateTime.Now
            });

            base.Seed(context);
        }

    }
}