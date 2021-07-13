using NearshoreDevs.Application.CQRS.RequestModels;
using System.Threading.Tasks;

namespace NearshoreDevs.Controllers.V1
{
    public  interface IStudentIdQueryHandler
    {
        Task<CustomerIdQueryResponseModel> GetStudentAsync(StudentIdQueryRequestModel requestModel);
    }
}