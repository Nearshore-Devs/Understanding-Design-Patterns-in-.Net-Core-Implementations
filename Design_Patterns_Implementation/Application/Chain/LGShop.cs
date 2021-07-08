using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.Chain
{
    public class LGShop: BaseRepairShop
    {
        public override void RepairTV(TVBrand brand)
        {
            if (brand == TVBrand.Sony)
            {
                Console.WriteLine("TV repaired by LG  center");
            }
            else if (_successor != null)
            {
                _successor.RepairTV(brand);
            }
        }
    }
}
