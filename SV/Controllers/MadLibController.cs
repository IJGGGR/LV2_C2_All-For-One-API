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
    public class MadLibController(MadLibService svc) : ControllerBase
    {
        private readonly MadLibService _svc = svc;

        [HttpGet("{creature_adjective}/{creature}/{place}/{things}/{adverb_1}/{adverb_2}/{base_verb}/{adverb_3}/{adverb_4}/{past_verb}")]
        public string MadLib(string creature_adjective, string creature, string place, string things, string adverb_1, string adverb_2, string base_verb, string adverb_3, string adverb_4, string past_verb)
        {
            return _svc.MadLib(creature_adjective, creature, place, things, adverb_1, adverb_2, base_verb, adverb_3, adverb_4, past_verb);
        }
    }
}
