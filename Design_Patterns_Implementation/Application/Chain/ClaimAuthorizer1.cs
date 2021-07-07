using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.Chain
{
    public class ClaimAuthorizer1: Authorizer
    {

        public override void ProcessClaim(IClaim claim)
        {
            if (claim.Amount > 1 && claim.Amount <100)
            {
                Console.WriteLine("Claim amount is under 100");
              }
            else if (_successor != null)
            {
                _successor.ProcessClaim(claim);
            }
        }
    }
}
