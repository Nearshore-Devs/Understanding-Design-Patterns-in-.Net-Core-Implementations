using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.Strategy
{
    public interface IClaim
    {
        public ClaimType Type { get; }
        public float Amount { get; }
    }
    public enum ClaimType { Pharmacy, Dental, Physician};
}
