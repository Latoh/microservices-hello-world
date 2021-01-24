using System;
using System.Collections.Generic;
using System.Text;

namespace HW.Domain
{
    public class MessageDto
    {

        public MessageDto(Message entity)
        {
            Id = entity.Id;
            Source = entity.Source;
            TextMessage = entity.TextMessage;
            Data = entity.Data;
        }

        public MessageDto(string textMessage)
        {
            TextMessage = textMessage;
        }

        public MessageDto()
        {

        }

        public virtual string Source { get; set; }
        public virtual Guid Id { get; set; }
        public virtual string TextMessage { get; set; }
        public virtual DateTime Data { get; set; }
    }
}
