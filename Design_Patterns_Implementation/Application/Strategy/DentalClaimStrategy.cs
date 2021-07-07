using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.Strategy
{
    public class DentalClaimStrategy : IStrategy
    {
        public void ProcessClaim(IClaim claim)
        {
            Console.WriteLine($"Dental Strategy, calculated amount: ${claim.Amount *1000} ");
        }
    }
}
