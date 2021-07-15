using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.Chain
{
    public abstract class BaseRepairShop: IRepairShop
    {
        protected IRepairShop _successor;
        protected string message = string.Empty;
        public void SetSuccessor(IRepairShop successor)
        {
            _successor = successor;
        }
        public abstract string RepairTV(string brandName, string errorDescription);
    }
}
