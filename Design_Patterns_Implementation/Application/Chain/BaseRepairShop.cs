using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.Chain
{
    public abstract class BaseRepairShop: IRepairShop
    {
        protected IRepairShop _successor;
        public void SetSuccessor(IRepairShop successor)
        {
            _successor = successor;
        }
        public abstract void RepairTV(TVBrand brand);
    }
}
