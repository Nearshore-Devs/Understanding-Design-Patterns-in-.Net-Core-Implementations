using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.Chain
{
    public interface IAuthorizer
    {
        void ProcessClaim(IClaim claim);
         void SetSuccessor(IAuthorizer successor);
        
    }
}
