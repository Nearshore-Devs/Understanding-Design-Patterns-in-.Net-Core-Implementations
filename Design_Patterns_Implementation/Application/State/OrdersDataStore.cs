using NearshoreDevs.Application.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application
{
    public class OrdersDataStore
    {
        private readonly IDictionary<string, DeliveryContext> _store;
        public OrdersDataStore()
        {
            _store = new Dictionary<string, DeliveryContext>();
        }

        public IDictionary<string, DeliveryContext> Store => _store;

        public string CreateNewOrder(string foodName)
        {
            var order = new Order() { FoodName = foodName };
            if(!_store.ContainsKey(order.OrderId))
            {
                _store.Add(order.OrderId, new DeliveryContext(null, order));
            }
            return order.OrderId;
        }
        public DeliveryContext GetOrderDeliveryContext(string id)
        {
            if(_store.ContainsKey(id))
            {
                return _store[id];
            }
            return null;
        }
    }
}
