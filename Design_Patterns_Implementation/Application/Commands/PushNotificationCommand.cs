using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.Commands
{
    public class PushNotificationCommand :  BaseNotificationCommand
    {
       
        public override void Execute()
        {
            Console.WriteLine("Push notification");
        }
        public override void DoSetup()
        {
            Console.WriteLine("Push notification");
        }
    }
}
