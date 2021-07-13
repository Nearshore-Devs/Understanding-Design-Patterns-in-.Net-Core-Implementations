using Microsoft.EntityFrameworkCore;
using NearshoreDevs.Application.CQRS.Interfaces.Queries;
using NearshoreDevs.Application.CQRS.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.CQRS.Handlers.Queries
{
    public class GetAllStudentsQueryHandler: IGetAllStudentsQueryHandler
    {
        private readonly StudentsDBContext context;

        public GetAllStudentsQueryHandler(StudentsDBContext context)
        {
            this.context = context;
        }
        public async Task<IList<AllStudentsQueryResponseModel>> GetAllAsync()
        {
            return await this.context.Students.Select(s => new AllStudentsQueryResponseModel
            {
                StudentId = s.Id,
                Name = $"{s.Title}.{s.Name }",
                Address = s.Address,
                Courses = s.Courses
            }).ToListAsync();
        }
    }
}
