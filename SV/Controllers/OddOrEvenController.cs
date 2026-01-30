using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SV.Services;

namespace SV.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OddOrEvenController(OddOrEvenService svc) : ControllerBase
    {
        private readonly OddOrEvenService _svc = svc;

        [HttpGet("{Number}")]
        public string OddOrEven(
            [FromRoute(Name = "Number")]
            double num
        )
        {
            return _svc.OddOrEven(num);
        }
    }
}
