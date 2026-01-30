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
