using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.Chain
{
    public abstract class  Authorizer: IAuthorizer
    {
       protected IAuthorizer _successor;

        public abstract void ProcessClaim(IClaim claim);
       

        public virtual void SetSuccessor(IAuthorizer successor)
        {
           _successor = successor;
        }
}
}
