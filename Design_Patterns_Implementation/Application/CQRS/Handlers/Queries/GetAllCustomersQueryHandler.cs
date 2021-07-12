using Microsoft.EntityFrameworkCore;
using NearshoreDevs.Application.CQRS.Interfaces.Queries;
using NearshoreDevs.Application.CQRS.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.CQRS.Handlers.Queries
{
    public class GetAllCustomersQueryHandler: IGetAllCustomerQueryHandler
    {
        private readonly CustomerDbContext context;

        public GetAllCustomersQueryHandler(CustomerDbContext context)
        {
            this.context = context;
        }
        public async Task<IList<AllCustomerQueryResponseModel>> GetAllAsync()
        {
            return await this.context.Customers.Select(s => new AllCustomerQueryResponseModel
            {
                CustomerId = s.Id,
                Name = $"{s.Title}.{s.Name }",
                Address = s.Address,
                Invoices = s.Invoices
            }).ToListAsync();
        }
    }
}
