using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.Mediator
{
    public class ATCMediator : IATCMediator
    {
        private Flight _flight;
        private Runway _runway;
       
        public bool LandingStatusOk { get; set ; }

        public void RegisterFlight(Flight flight)
        {
            _flight = flight;
        }

        public void RegisterRunway(Runway runway)
        {
            _runway = runway;
        }
    }
}
