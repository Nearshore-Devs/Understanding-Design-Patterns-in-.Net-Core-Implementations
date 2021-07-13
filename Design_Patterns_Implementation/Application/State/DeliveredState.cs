using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.State
{
    public class DeliveredState: IState
    {
       

        public DeliveredState()
        {
          
        }

        public string StateName => "Delivered";

        public void ProcessOrder(DeliveryContext context)
        {
            Console.WriteLine("Order has been delivered");
        }
    }
}
