using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.Strategy
{
    public class PharmacyClaimStrategy : IStrategy
    {
        public void ProcessClaim(IClaim claim)
        {
            Console.WriteLine($"Pharmacy Strategy, calculated amount ${claim.Amount * 100} ");
           
        }
    }
}
