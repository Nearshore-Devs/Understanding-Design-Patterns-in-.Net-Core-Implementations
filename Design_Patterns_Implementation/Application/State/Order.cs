using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.State
{
    public class Order
    {
        Guid _orderId = new Guid();
        public string OrderId => _orderId.ToString();
        public string MealName { get; set; }

       
    }
}
