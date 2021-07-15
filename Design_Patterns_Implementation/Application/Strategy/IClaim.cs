using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.Strategy
{
    public class Claim

    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        /// <summary>
        /// National Provider Identification
        /// </summary>
        public string NPI { get; set; }
        /// <summary>
        /// Internal Control Number
        /// </summary>
        public string ICN { get; set; }
       
       
        public string Description { get; set; }
        public float AllowedAmount { get; set; }

        public IList<ClaimDetail> Details { get; set; }
        public Provider  Provider { get; set; }
    }
    
}
