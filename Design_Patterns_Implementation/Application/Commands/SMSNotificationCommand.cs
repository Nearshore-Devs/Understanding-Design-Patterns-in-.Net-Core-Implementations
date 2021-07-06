using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.Commands
{
    public class SMSNotificationCommand : INotificationCommand
    {
        public void Execute(NotificationType type, string title, string body, IDictionary<string, string> extraData)
        {
            throw new NotImplementedException();
        }
    }
}
