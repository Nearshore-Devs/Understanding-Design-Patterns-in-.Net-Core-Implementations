using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.Chain
{
    public class SonyShop : BaseRepairShop
    {
        public override string RepairTV(string brandName, string errorDescription)
        {
           if(brandName.Contains("sony", StringComparison.InvariantCultureIgnoreCase))
            {
                message = "TV repaired by sony  center";
                Console.WriteLine("TV repaired by sony  center");
            }
            else if (_successor != null)
            {
                message= _successor.RepairTV(brandName, errorDescription);
            }
            return message;
        }
    }
}
