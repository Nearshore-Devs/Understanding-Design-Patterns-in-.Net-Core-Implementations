using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.Mediator
{
    public class MediatorClient
    {
        public void Run()
        {
            IATCMediator atcMediator = new ATCMediator();
            Flight sparrow101 = new Flight(atcMediator);
            Runway mainRunway = new Runway(atcMediator);
            atcMediator.RegisterFlight(sparrow101);
            atcMediator.RegisterRunway(mainRunway);
            sparrow101.GetReady();
            mainRunway.Land();
            sparrow101.Land();
        }
    }
}
