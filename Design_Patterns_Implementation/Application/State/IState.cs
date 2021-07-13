using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.State
{
    public interface IState
    {
        string StateName { get; }
        void ProcessOrder(DeliveryContext context);
     }
}
