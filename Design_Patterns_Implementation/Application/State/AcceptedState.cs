using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.State
{
    public class AcceptedState:IState
    {


        public string StateName => "Accepted";


        public void ProcessOrder(DeliveryContext context)
        {
            Console.WriteLine("Order has been accepted");
            context.SetCurrentState(new PreparingState());
        }
    }
}
