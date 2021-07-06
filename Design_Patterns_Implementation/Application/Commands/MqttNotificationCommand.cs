using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.Commands
{
    public class MqttNotificationCommand : BaseNotificationCommand
    {
        private MqttReceiver _receiver;
        public MqttNotificationCommand(MqttReceiver receiver)
        {
            _receiver = receiver;
        }
        public override void Execute()
        {
            _receiver.SetupServer();
            _receiver.SendMessage(Title = this.Title, Body = this.Body);

        }
    }
}
