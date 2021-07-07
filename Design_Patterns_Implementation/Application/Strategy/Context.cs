using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.Strategy
{
    public class Context
    {
        readonly IStrategy _strategy;


        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ProcessClaim(IClaim claim)
        {
            _strategy.ProcessClaim(claim);
        }

    }
}
