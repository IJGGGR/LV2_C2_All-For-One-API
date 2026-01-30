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
    public class AskTwoQuestionsController(AskTwoQuestionsService svc) : ControllerBase
    {
        private readonly AskTwoQuestionsService _svc = svc;

        [HttpGet("{YourName}/{WakeTime}")]
        public ActionResult<string> AddTwoNumbers(
            [FromRoute(Name = "YourName")]
            string one,
            [FromRoute(Name = "WakeTime")]
            string two
        )
        {
            return _svc.AskTwoQuestions(one, two);
        }
    }
}
