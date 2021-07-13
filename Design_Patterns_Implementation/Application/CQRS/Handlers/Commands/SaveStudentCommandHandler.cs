using NearshoreDevs.Application.CQRS.Interfaces;
using NearshoreDevs.Application.CQRS.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.CQRS.Handlers.Commands
{
    public class SaveStudentCommandHandler : ISaveStudentCommandHandler
    {
        private readonly StudentsDBContext context;

        public SaveStudentCommandHandler(StudentsDBContext context)
        {
            this.context = context;
        }
        public async Task<int> SaveAsync(SaveStudentRequestModel saveCustomerRequestModel)
        {
            var newStudent = new Student
            {
                Name = saveCustomerRequestModel.Name,
                Title = saveCustomerRequestModel.Title,
                Address = saveCustomerRequestModel.Address,
                Courses = saveCustomerRequestModel.Courses
            };

            context.Students.Add(newStudent);
            await this.context.SaveChangesAsync();
            return newStudent.Id;
        }
    }
}
