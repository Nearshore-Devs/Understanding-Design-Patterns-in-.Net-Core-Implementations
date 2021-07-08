using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.Mediator
{
    public class Flight: ICommand
    {
        private readonly IATCMediator _atcMediator;

        public Flight(IATCMediator atcMediator)
        {
            _atcMediator = atcMediator;
        }

        public void Land()
        {
            if (_atcMediator.LandingStatusOk)
            {
                Console.WriteLine("Successfully Landed.");
                _atcMediator.LandingStatusOk = true;
            }
            else
                Console.WriteLine("Waiting for landing.");
        }

        public void GetReady()
        {
            Console.WriteLine("Ready for landing.");
        }
    }
}
