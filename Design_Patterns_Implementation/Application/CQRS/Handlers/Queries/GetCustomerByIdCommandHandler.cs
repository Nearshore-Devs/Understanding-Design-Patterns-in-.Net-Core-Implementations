using NearshoreDevs.Application.CQRS.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NearshoreDevs.Application.CQRS.Interfaces.Queries;

namespace NearshoreDevs.Application.CQRS.Handlers.Queries
{
    public class GetCustomerByIdCommandHandler: IGetCustomerByIdQueryHandler
    {
        private readonly CustomerDbContext context;
        public GetCustomerByIdCommandHandler(CustomerDbContext context)
        {
            this.context = context;
        }
        public async Task<CustomerIdQueryResponseModel> GetCustomerAsync(CustomerIdQueryRequestModel requestModel)
        {
            var result =  await this.context.Customers.Where(p => p.Id == requestModel.CustomerId)
                .FirstOrDefaultAsync();
                       

            if (result != null)
            {
                return new CustomerIdQueryResponseModel
                {
                    CustomerId = result.Id,
                    Name = $"{result.Title}.{result.Name}",
                    Address = result.Address
                };
            }

            return null;
        }
    }
}
