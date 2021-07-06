using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.Commands
{
    public interface INotificationCommand
    {
        void Execute();
    }




    public enum NotificationType { Push, SMS, Mqtt};
}
