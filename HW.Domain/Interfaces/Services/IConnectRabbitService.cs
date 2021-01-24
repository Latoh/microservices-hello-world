using HW.Infra;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW.Domain.Interfaces.Services
{
    public interface IConnectRabbitService : IServiceBase
    {
        void CreateConnection();
        bool ConnectionExists();
        string ReturnQueueName();
    }
}
