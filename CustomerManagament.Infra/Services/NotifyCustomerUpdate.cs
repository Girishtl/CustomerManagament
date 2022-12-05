using CustomerManagament.Core.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagament.Infra.Notification
{
    public class NotifyCustomerUpdate : INotifiyCustomerUpdate
    {
        private string _queueName;
        private string _queueConnectionString;

        public NotifyCustomerUpdate(IConfiguration configuration)
        {
            _queueConnectionString = configuration["_queueConnectionString"];
            _queueName = configuration["QueueName"];
        }

        public Task PushCustomerNotification()
        {
            return Task.CompletedTask;
        }
    }
}
