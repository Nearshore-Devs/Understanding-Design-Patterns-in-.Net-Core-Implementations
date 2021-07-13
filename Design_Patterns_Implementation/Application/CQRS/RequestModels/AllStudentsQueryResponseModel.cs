using NearshoreDevs.Application.CQRS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.CQRS.RequestModels
{
    public class AllStudentsQueryResponseModel
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public IList<Course> Courses { get; set; }
    }
}
