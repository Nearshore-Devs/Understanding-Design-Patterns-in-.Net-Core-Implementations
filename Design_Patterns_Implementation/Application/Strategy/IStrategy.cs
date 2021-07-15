using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.Strategy
{
    public interface IStrategy
    {
        public Claim ProcessClaim(Claim claim);
    }
}
