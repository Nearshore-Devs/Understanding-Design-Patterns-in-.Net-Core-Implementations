using NearshoreDevs.Application.CQRS.Interfaces;
using NearshoreDevs.Application.CQRS.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.CQRS.Handlers.Commands
{
    public class SaveCustomerCommandHandler : ISaveCustomerCommandHandler
    {
        private readonly CustomerDbContext context;

        public SaveCustomerCommandHandler(CustomerDbContext context)
        {
            this.context = context;
        }
        public async Task<int> SaveAsync(SaveCustomerRequestModel saveCustomerRequestModel)
        {
            var newCustomer = new Customer
            {
                Name = saveCustomerRequestModel.Name,
                Title = saveCustomerRequestModel.Title,
                Address = saveCustomerRequestModel.Address,
                Invoices = saveCustomerRequestModel.Invoices
            };

            context.Customers.Add(newCustomer);
            await this.context.SaveChangesAsync();
            return newCustomer.Id;
        }
    }
}
