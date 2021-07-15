using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.Chain
{
    public class LGShop: BaseRepairShop
    {
        public override string RepairTV(string brandName, string errorDescription)
        {
            if (brandName.Contains("lg", StringComparison.InvariantCultureIgnoreCase))
            {
                message = "TV repaired by LG  center";
                Console.WriteLine(message);
            }
            else if (_successor != null)
            {
                message= _successor.RepairTV(brandName, errorDescription);
            }
            return message;
        }
    }
}
