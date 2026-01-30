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
    public class GuessItController(GuessItService svc) : ControllerBase
    {
        private readonly GuessItService _svc = svc;

        [HttpGet("EasyMode/{YourGuess}")]
        public ActionResult<string> EasyMode(
            [FromRoute(Name = "YourGuess")]
            int num
        )
        {
            if (num < 1 || num > 10) return BadRequest("Out of range.");
            return _svc.GuessIt(num, 1, 10);
        }

        [HttpGet("MediumMode/{YourGuess}")]
        public ActionResult<string> MediumMode(
            [FromRoute(Name = "YourGuess")]
            int num
        )
        {
            if (num < 1 || num > 50) return BadRequest("Out of range.");
            return _svc.GuessIt(num, 1, 50);
        }

        [HttpGet("HardMode/{YourGuess}")]
        public ActionResult<string> HardMode(
            [FromRoute(Name = "YourGuess")]
            int num
        )
        {
            if (num < 1 || num > 100) return BadRequest("Out of range.");
            return _svc.GuessIt(num, 1, 100);
        }
    }
}
