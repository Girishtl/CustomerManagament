using Azure.Identity;
using Azure.Messaging.ServiceBus;
using CustomerManagament.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagament.Infra.Notification
{
    public class ServiceBusQueuSender : IServiceBusQueuSender
    {
        ServiceBusClient svcClient = new ServiceBusClient("sessiondemoanish.servicebus.windows.net", new DefaultAzureCredential());
        public bool SendMessageQueue(string message)
        {
            ServiceBusSender ServiceBusClient = svcClient.CreateSender("CustomerMangaement");
             ServiceBusClient.SendMessageAsync(new ServiceBusMessage($"Message")
            {
               
            });
            return  true;
        }
    }
}
