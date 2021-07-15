using NearshoreDevs.Application.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Dtos
{
    public class ClaimDto
    {
        public string ICN { get; set; }
        public string NPI { get; set; }
       
     
        public string Description { get; set; }

        public IEnumerable<ClaimDetail> Details{ get; set; }
}
}
