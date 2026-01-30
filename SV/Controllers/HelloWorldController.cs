using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SV.Services;

//// hello world
//// asking questions
//// adding two numbers
//// madlib
//// odd or even
//// reverse it (alphanumeric)
//// reverse it (numeric)
//// magic 8 ball
//// guess it
//// restaurant picker
// step-by-step pdf for creating a hello world endpoint via swagger (detailed explanations and images)

namespace SV.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloWorldController(HelloWorldService svc) : ControllerBase
    {
        private readonly HelloWorldService _svc = svc;

        [HttpGet]
        public ActionResult<string> HelloWorld()
        {
            return _svc.HelloWorld();
        }
    }
}
