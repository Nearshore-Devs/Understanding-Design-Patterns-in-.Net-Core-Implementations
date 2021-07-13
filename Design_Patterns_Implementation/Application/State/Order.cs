using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.State
{
    public class Order
    {
        Guid _orderId = Guid.NewGuid();
       
        
        public string OrderId => _orderId.ToString();
        public string FoodName { get; set; }

       
    }
}
