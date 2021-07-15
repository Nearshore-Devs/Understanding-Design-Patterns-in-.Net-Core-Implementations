using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NearshoreDevs.Application.Strategy;
using NearshoreDevs.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearshoreDevs.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimsController : ControllerBase
    {
        private readonly ClaimContext _ctx;
        public ClaimsController(ClaimContext ctx)
        {
            _ctx = ctx;
        }


        [HttpPost]
        public IActionResult ProcessClaim(ClaimDto claimDto)
        {
            var claim = new Claim
            { 
                Description= claimDto.Description,
                ICN=claimDto.ICN,
                NPI= claimDto.NPI,
                
            };
           return Ok( _ctx.ProcessClaim(claim));
        }
    }
}
