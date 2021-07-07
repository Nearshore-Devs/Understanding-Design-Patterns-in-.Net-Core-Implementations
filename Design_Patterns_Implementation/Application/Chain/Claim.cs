using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.Chain
{
    public class Claim : IClaim
    {
        public float Amount { get; set; };
        public Claim(float amount)
        {
            Amount = amount;
        }
    }
}
