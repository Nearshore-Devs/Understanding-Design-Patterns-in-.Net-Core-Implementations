using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.Commands
{
    public class Invoker
    {
        IDictionary<NotificationType, INotificationCommand> _commands = new Dictionary<NotificationType, INotificationCommand>();

        public Invoker()
        {
            
        }  

        private void InitializeCommands(string title, string body, IDictionary<string, string> data)
        {
            _commands.Clear();
            _commands.Add(NotificationType.Mqtt, new MqttNotificationCommand 
            { 
                Body= body,
                Data= data,
                Title= title

            });
            _commands.Add(NotificationType.Push, new PushNotificationCommand
            {
                Body = body,
                Data = data,
                Title = title

            });
            _commands.Add(NotificationType.SMS, new SMSNotificationCommand
            {
                Body = body,
                Data = data,
                Title = title

            });

        }
        public INotificationCommand GetNotificationCommand(NotificationType type, string title, string body, IDictionary<string, string> extraData)
        {
            InitializeCommands( title,  body,  extraData);
            if (_commands.ContainsKey(type))
                return _commands[type];
            throw new NotImplementedException("Not implemented");
        }
    }
}
