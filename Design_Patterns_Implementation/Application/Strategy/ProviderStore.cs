using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.Strategy
{
    public class ProviderStore
    {
        private readonly IDictionary<string, Provider> _data;

        public ProviderStore(IDictionary<string, Provider> data)
        {
            _data = data;

        }

        public Provider GetProvider(string NPI)
        {
            if (_data.ContainsKey(NPI))
                return _data[NPI];
            return null;
        }

    }
}
