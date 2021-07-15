using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.Strategy
{
    public class ClaimContext
    {
        readonly ProviderStore _store;


        public ClaimContext(ProviderStore store)
        {
            _store = store;
        }

        public float ProcessClaim(Claim claim)
        {
            float amount = 0;
            var strategy = BuildStrategy(claim.NPI);
            if(strategy!=null)
            {
              var result=  strategy.ProcessClaim(claim);
                amount= result.AllowedAmount;
            }
            return amount;
        }
        private IStrategy BuildStrategy(string NPI)
        {
            IStrategy strategy = null;
            var provider = _store.GetProvider(NPI);
            switch(provider.Type)
            {
                case ProviderType.Dental:
                    strategy = new DentalClaimStrategy();
                    break;
                case ProviderType.Pharmacy:
                    strategy = new PharmacyClaimStrategy();
                    break;
                case ProviderType.Phisycian:
                    strategy = new PhysicianClaimStrategy();
                    break;
            }
            return strategy;

        }

    }
}
