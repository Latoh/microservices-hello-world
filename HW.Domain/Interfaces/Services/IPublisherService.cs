using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HW.Domain.Interfaces.Services
{
    public interface IPublisherService : IServiceBase
    {
        string SendMessage(Message message);
    }
}
