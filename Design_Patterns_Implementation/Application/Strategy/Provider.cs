using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.Strategy
{
    public class Provider
    {
        public string NPI { get; set; }
        public int CreditDayNumber { get; set; }
        public ProviderType Type { get; set; }
    }


    public enum ProviderType { Dental, Phisycian, Pharmacy};
}
