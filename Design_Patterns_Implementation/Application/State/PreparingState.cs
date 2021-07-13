using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.State
{
    public class PreparingState : IState
    {
        public string StateName => "Preparing";
        public void ProcessOrder(DeliveryContext context)
        {
            Console.WriteLine("Order is being prepared");
            context.SetCurrentState(new OutForDeliveringState());
        }
    }
}
