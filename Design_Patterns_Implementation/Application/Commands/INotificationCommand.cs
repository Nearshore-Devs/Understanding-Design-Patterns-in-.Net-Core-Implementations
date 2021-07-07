using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.Commands
{
    public interface INotificationCommand: ICommand
    {
        void DoSetup();

        public string Title { get; set; }
        public string Body { get; set; }
        public IDictionary<string, string> Data { get; set; }

    }




    public enum NotificationType { Push, SMS, Mqtt};
}
