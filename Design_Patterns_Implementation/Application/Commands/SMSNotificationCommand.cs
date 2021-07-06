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
        public override void Execute()
        {
            _receiver.SetupSMSServer();
            _receiver.SendSMS(Title = this.Title, Body = this.Body, Data = this.Data);
        }
    }
}
