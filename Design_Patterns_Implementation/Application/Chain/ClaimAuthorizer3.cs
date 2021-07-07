using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.Chain
{
    public class ClaimAuthorizer3 : Authorizer
    {
        public override void ProcessClaim(IClaim claim)
        {
            if (claim.Amount >= 1000 )
            {
                Console.WriteLine("Claim amount is above 10000");
            }
            else if (_successor != null)
            {
                _successor.ProcessClaim(claim);
            }
        }
    }
}
