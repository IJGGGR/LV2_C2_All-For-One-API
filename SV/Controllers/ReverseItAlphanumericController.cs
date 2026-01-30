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
    public class ReverseItAlphanumericController(ReverseItAlphanumericService svc) : ControllerBase
    {
        private readonly ReverseItAlphanumericService _svc = svc;

        [HttpGet("{StringToReverse}")]
        public ActionResult<string> ReverseIt(
            [FromRoute(Name = "StringToReverse")]
            string str
        )
        {
            var res = _svc.ReverseIt(str);
            if (res == null) return BadRequest("String must be alphanumeric.");
            return res;
        }
    }
}
