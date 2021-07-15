using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.Strategy
{
    public class DentalClaimStrategy : IStrategy
    {
        public Claim ProcessClaim(Claim claim)
        {
            var amount = 0.0;
            amount = claim.Details.Sum(d => d.Price * d.Quantity);
            claim.Date = DateTime.Now;
            Console.WriteLine($"Dental Strategy, calculated amount ${amount } ");
            return claim;
        }
    }
}
