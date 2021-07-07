using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.Strategy
{
    public class PhysicianClaimStrategy : IStrategy
    {
        public void ProcessClaim(IClaim claim)
        {
            Console.WriteLine($"Physician Strategy, calculated amount: ${claim.Amount*10} ");
        }
    }
}
