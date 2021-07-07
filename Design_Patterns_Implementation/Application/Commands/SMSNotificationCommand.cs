using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.Commands
{
    public class SMSNotificationCommand :  BaseNotificationCommand
    {
        private readonly SMSReceiver _receiver;
        public SMSNotificationCommand(SMSReceiver receiver)
        {
            _receiver = receiver;
        }
        public override void DoSetup()
        {
            _receiver.SetupSMSServer();
        }
        public override void Execute()
        {
            
            _receiver.SendSMS(Title,  Body,  Data);
        }
    }
}
