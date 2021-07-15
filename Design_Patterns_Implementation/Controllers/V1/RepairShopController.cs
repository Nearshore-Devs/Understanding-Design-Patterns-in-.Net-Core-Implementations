using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NearshoreDevs.Application.Chain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepairShopController : ControllerBase
    {
        private readonly IRepairShop _repairShop;
        public RepairShopController(IRepairShop repairShop)
        {
            _repairShop = repairShop;
        }

        [HttpPost("repairtv")]
        public IActionResult Repair([FromBody] TVRepairViewModel model)
        {
            return Ok(_repairShop.RepairTV(model.BrandName, model.ErrorDescription));
        }
    }
}
