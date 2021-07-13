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
    public class StudentController : Controller
    {
        private readonly ISaveStudentCommandHandler _saveStudentCommandHandler;
        private readonly IGetAllStudentsQueryHandler _getAllStudentQueryHandler;
        private readonly IStudentIdQueryHandler _studentIdQueryHandler;

        public StudentController(
            ISaveStudentCommandHandler saveStudentCommandHandler,
            IGetAllStudentsQueryHandler allStudentQueryHandler,
            IStudentIdQueryHandler studentIdQueryHandler)
        {
            _saveStudentCommandHandler = saveStudentCommandHandler;
            _getAllStudentQueryHandler = allStudentQueryHandler;
            _studentIdQueryHandler = studentIdQueryHandler;
        }

        [HttpPost]
       
        public async Task<IActionResult> SaveStudentAsync(SaveStudentRequestModel requestModel)
        {
            try
            {
               
                var result = await _saveStudentCommandHandler.SaveAsync(requestModel);
                return Ok(result);
            }
            catch
            {
                throw;
            }
        }

        [HttpGet]
       
        public async Task<IActionResult> GetAllStudentsAsync()
        {
            try
            {
                return Ok(await _getAllStudentQueryHandler.GetAllAsync());
            }
            catch
            {
                throw;
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudentAsync(StudentIdQueryRequestModel model)
        {
            try
            {
                var result = await _studentIdQueryHandler.GetStudentAsync(model);
                if (result != null)
                {
                    return Ok(result);
                }
                return NotFound($"Student Id '{model.StudentId}' does not exists!!");
            }
            catch
            {
                throw;
            }
        }
    }
}
}
