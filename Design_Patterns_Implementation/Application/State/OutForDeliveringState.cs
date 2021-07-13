using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.State
{
    public class OutForDeliveringState:IState
    {
      
        
        public string StateName => "Out for delivering";
        public void ProcessOrder(DeliveryContext context)
        {
            Console.WriteLine("Order is out for delivering");
            context.SetCurrentState(new DeliveredState());
        }
    }
}
