using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.State
{
    public class DeliveryContext
    {
        Order _order;
        IState _currentState;
        public DeliveryContext(IState state, Order order)
        {
            _order = order;
            _currentState = state;
            if (_currentState == null)
            {
                _currentState = new AcceptedState();
            }
           
        }
        public string OrderId => _order.OrderId;

        public IState CurrentState => _currentState;

        public void SetCurrentState(IState state)
        {
            _currentState = state;

        }

        public void UpdateOrderStatus()
        {
            _currentState.ProcessOrder(this);
        }
    }
}
