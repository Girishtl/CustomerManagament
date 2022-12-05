using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagament.Core.Services.Interfaces
{
    public interface IServiceBusQueuSender
    {
        bool SendMessageQueue(string message);
    }
}
