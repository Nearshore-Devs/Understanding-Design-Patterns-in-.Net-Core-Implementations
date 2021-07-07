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
          
            _receiver.SendMessage(Title = Title, Body = Body);

        }
        public override void DoSetup()
        {
            _receiver.SetupServer();
        }
    }
}
