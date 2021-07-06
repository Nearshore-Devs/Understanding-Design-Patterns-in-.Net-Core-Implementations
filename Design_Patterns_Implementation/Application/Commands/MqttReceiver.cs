using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.Commands
{
    public class MqttReceiver
    {
        public void SetupServer()
        {
            Console.WriteLine("Server initialized");
        }
        public void SendMessage(string title, string content )
        {
            Console.WriteLine("Mqtt notification sent");
        }
    }
}
