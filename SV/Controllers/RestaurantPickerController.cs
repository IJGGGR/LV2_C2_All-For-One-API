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
    public class RestaurantPickerController(RestaurantPickerService svc) : ControllerBase
    {
        private readonly RestaurantPickerService _svc = svc;

        [HttpGet("{FoodCategory}")]
        public ActionResult<string> RestaurantPicker(
            [FromRoute(Name = "FoodCategory")]
            string str
        )
        {
            int num = str.Trim().ToLower() switch
            {
                "f" or "fast" => 0,
                "m" or "mexican" => 1,
                "i" or "italian" => 2,
                _ => -1,
            };
            if (num < 0) return BadRequest("VALID CATEGORIES: fast, mexican, italian.");
            return _svc.RestaurantPicker(num);
        }
    }
}
