using NearshoreDevs.Application.CQRS.RequestModels;
using System.Threading.Tasks;

namespace NearshoreDevs.Controllers.V1
{
    public  interface ICustomerIdQueryHandler
    {
        Task<CustomerIdQueryResponseModel> GetCustomerAsync(CustomerIdQueryRequestModel requestModel);
    }
}