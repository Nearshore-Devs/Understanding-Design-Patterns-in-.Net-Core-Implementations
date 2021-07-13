using NearshoreDevs.Application.CQRS.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NearshoreDevs.Application.CQRS.Interfaces.Queries;

namespace NearshoreDevs.Application.CQRS.Handlers.Queries
{
    public class GetStudentByIdCommandHandler: IGetStudentByIdQueryHandler
    {
        private readonly StudentsDBContext context;
        public GetStudentByIdCommandHandler(StudentsDBContext context)
        {
            this.context = context;
        }
        public async Task<StudentIdQueryResponseModel> GetStudentAsync(StudentIdQueryRequestModel requestModel)
        {
            var result =  await this.context.Students.Where(p => p.Id == requestModel.StudentId)
                .FirstOrDefaultAsync();
                       

            if (result != null)
            {
                return new StudentIdQueryResponseModel
                {
                    StudentId = result.Id,
                    Name = $"{result.Title}.{result.Name}",
                    Address = result.Address
                };
            }

            return null;
        }
    }
}
