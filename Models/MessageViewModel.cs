using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KakoytoMessenger.Models
{
    public class MessageViewModel
    {
        public List<MessageViewData> Data { get; set; }
    }

    public class MessageViewData 
    {
        public string TextMessage { get; set; }
    }
}