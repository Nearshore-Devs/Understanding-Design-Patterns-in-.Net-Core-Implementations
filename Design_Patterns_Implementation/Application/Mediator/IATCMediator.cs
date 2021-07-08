using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.Mediator
{
    public interface IATCMediator
    {
         void RegisterRunway(Runway runway);

         void RegisterFlight(Flight flight);

        bool LandingStatusOk { get; set; }

       
    }
}
