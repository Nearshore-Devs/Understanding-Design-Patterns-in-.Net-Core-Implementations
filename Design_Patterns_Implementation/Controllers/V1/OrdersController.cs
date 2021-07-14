using Microsoft.AspNetCore.Mvc;
using NearshoreDevs.Application;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearshoreDevs.Controllers.V1
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : Controller
    {
        private readonly OrdersDataStore _store;
        public OrdersController(OrdersDataStore store)
        {
            _store = store;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrderAsync()
        {
            string foodName = string.Empty;
            using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                foodName = await reader.ReadToEndAsync();
            }
            return Ok(_store.CreateNewOrder(foodName));

        }
        [HttpGet("{id}/status")]
        public IActionResult GetOrderStatus(string id)
        {
            var context = _store.GetOrderDeliveryContext(id);
            if (context != null)
            {
                return Ok(context.CurrentState.StateName);
            }
            return NotFound("Order Id does not exist!");

        }

        [HttpGet("{id}")]
        public IActionResult ChangeOrderStatus(string id)
        {
            var context = _store.GetOrderDeliveryContext(id);
            if (context != null)
            {
                context.UpdateOrderStatus();

                return Ok(context.CurrentState.StateName);
            }
            return NotFound("Order Id does not exist!");

        }
    }
}
