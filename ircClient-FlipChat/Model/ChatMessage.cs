using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ircClient_FlipChat.Model
{
    public class ChatMessage
    {
       
        public DateTime Time { get; set; }
        public string Nick { get; set; }
        public string Message { get; set; }               
       
          public ChatMessage()
        {
            Time = DateTime.Now;
            Nick = "kut";
            Message = "super chat kut";
        }
        
    }
}
