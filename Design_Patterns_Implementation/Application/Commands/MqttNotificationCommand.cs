using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.Commands
{
    public class MqttNotificationCommand : BaseNotificationCommand
    {
        public override void Execute()
        {
            Console.WriteLine('Mqtt notification');
        }
    }
}
