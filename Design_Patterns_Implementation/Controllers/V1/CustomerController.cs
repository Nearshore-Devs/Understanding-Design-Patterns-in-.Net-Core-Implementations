using Microsoft.AspNetCore.Mvc;
using NearshoreDevs.Application.CQRS.Interfaces;
using NearshoreDevs.Application.CQRS.Interfaces.Queries;
using NearshoreDevs.Application.CQRS.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Controllers.V1
{
    public class CustomerController : Controller
    {
        private readonly ISaveCustomerCommandHandler _saveCustomerCommandHandler;
        private readonly IGetAllCustomerQueryHandler _getAllallCustomerQueryHandler;
        private readonly ICustomerIdQueryHandler _customerIdQueryHandler;

        public CustomerController(
            ISaveCustomerCommandHandler saveCustomerCommandHandler,
            IGetAllCustomerQueryHandler allCustomerQueryHandler,
            ICustomerIdQueryHandler customerIdQueryHandler)
        {
            _saveCustomerCommandHandler = saveCustomerCommandHandler;
            _getAllallCustomerQueryHandler = allCustomerQueryHandler;
            _customerIdQueryHandler = customerIdQueryHandler;
        }

        [HttpPost]
       
        public async Task<IActionResult> SaveCustomerAsync(SaveCustomerRequestModel requestModel)
        {
            try
            {
                var result = await _saveCustomerCommandHandler.SaveAsync(requestModel);
                return Ok(result);
            }
            catch
            {
                throw;
            }
        }

        [HttpGet]
       
        public async Task<IActionResult> GetAllCustomerAsync()
        {
            try
            {
                return Ok(await _getAllallCustomerQueryHandler.GetAllAsync());
            }
            catch
            {
                throw;
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomerAsync(CustomerIdQueryRequestModel model)
        {
            try
            {
                var result = await _customerIdQueryHandler.GetCustomerAsync(model);
                if (result != null)
                {
                    return Ok(result);
                }
                return NotFound($"Customer Id '{model.CustomerId}' does not exists!!");
            }
            catch
            {
                throw;
            }
        }
    }
}
}
