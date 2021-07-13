using NearshoreDevs.Application.CQRS.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.CQRS.Interfaces.Queries
{
    public interface IGetStudentByIdQueryHandler
    {
        Task<StudentIdQueryResponseModel> GetStudentAsync(StudentIdQueryRequestModel requestModel);
    }
}
