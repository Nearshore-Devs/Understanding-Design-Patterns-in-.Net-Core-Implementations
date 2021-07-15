using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.Chain
{
    public class DaewooShop : BaseRepairShop
    {
        public override string  RepairTV(string brandName, string errorDescription)
        {
            
            if (brandName.Contains("daewoo", StringComparison.InvariantCultureIgnoreCase))
            {
                 message = "TV repaired by Daewoo  center";
                Console.WriteLine(message);
                
            }
            else if (_successor != null)
            {
                message= _successor.RepairTV(brandName, errorDescription);
            }
            else
            {
                message = "The brand is invalid or not supported for the existing shops";
            }
            return message;
        }
    }
}
