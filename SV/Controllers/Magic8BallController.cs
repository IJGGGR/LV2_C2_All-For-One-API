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
    public class Magic8BallController(Magic8BallService svc) : ControllerBase
    {
        private readonly Magic8BallService _svc = svc;

        [HttpGet("{YourQuestion}")]
        public ActionResult<string> Magic8Ball(
            [FromRoute(Name = "YourQuestion")]
            string str
        )
        {
            if (str == null || str.Trim() == "") return BadRequest();
            return _svc.Magic8Ball();
        }
    }
}
