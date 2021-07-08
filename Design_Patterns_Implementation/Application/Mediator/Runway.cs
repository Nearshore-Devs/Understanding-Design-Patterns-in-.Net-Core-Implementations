using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.Mediator
{
    public class Runway : ICommand
    {
        private readonly IATCMediator _atcMediator;

        public Runway(IATCMediator atcMediator)
        {
            _atcMediator = atcMediator;
        }

        public void Land()
        {
           Console.WriteLine("Landing permission granted.");
            _atcMediator.LandingStatusOk = true; 
        }
    }
}
