using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Application.Chain
{
    public interface IRepairShop
    {
        void RepairTV(TVBrand brand);
    }


    public enum TVBrand { Sony, Daewoo, LG};
}
