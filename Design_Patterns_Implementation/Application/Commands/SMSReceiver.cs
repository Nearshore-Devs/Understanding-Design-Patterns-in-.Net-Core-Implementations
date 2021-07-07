using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.Commands
{
    public class SMSReceiver
    {
        public void SetupSMSServer()
        {
            Console.WriteLine("SMS server activated");
        }
        
        public void SendSMS(string title, string body, IDictionary<string, string> data)
        {
            Console.WriteLine($"SMS notification sent: {title} - {body} , data arguments: {data.Count}");
        }
    }
}
