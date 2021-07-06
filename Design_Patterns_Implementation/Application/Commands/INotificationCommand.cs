using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.Commands
{
    public interface INotificationCommand
    {
        void Execute(NotificationType type, string title, string body, IDictionary<string , string> extraData);
    }


    public enum NotificationType { Push, SMS, Mqtt};
}
