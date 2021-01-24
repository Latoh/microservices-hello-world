using System;
using System.Collections.Generic;
using System.Text;

namespace HW.Domain
{
    public class Message : EntityBase
    {
        public Message(string textMessage)
        {
            TextMessage = textMessage;
        }

        public virtual string TextMessage { get; set; }

    }
}
