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
    public class AddTwoNumbersController(AddTwoNumbersService svc) : ControllerBase
    {
        private readonly AddTwoNumbersService _svc = svc;

        [HttpGet("{NumberOne}/{NumberTwo}")]
        public ActionResult<string> AddTwoNumbers(
            [FromRoute(Name = "NumberOne")]
            double one,
            [FromRoute(Name = "NumberTwo")]
            double two
        )
        {
            return _svc.AddTwoNumbers(one, two);
        }
    }
}
