using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.Commands
{
    public abstract  class BaseNotificationCommand : INotificationCommand
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public IDictionary<string, string> Data { get; set; }

        public abstract void DoSetup();
        

        public abstract void Execute();
       
    }
}
