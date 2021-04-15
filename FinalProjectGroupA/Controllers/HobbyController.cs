using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FinalProjectGroupA.Data;
using FinalProjectGroupA.Models;
using Microsoft.AspNetCore;

namespace FinalProjectGroupA.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HobbiesController : ControllerBase
    {
        private ILogger<HobbiesController> _logger;
        private TeamContext _ctx;
        public HobbiesController(ILogger<HobbiesController> logger, TeamContext ctx)
        {
            _logger = logger;
            _ctx = ctx;
        }

        [HttpGet]
        [ApiConventionMethod(typeof(DefaultApiConventions),
        nameof(DefaultApiConventions.Get))]
        public IActionResult Get(int? id)
        {
            if (id== null || id < 1)
                return Ok(_ctx.Hobbies.Take(5).ToList());
            var hobby = _ctx.Hobbies.Find(id);
            if (hobby == null)
                return NotFound();
            
            return Ok(hobby);
        }

        [HttpPut]
        [ApiConventionMethod(typeof(DefaultApiConventions),
        nameof(DefaultApiConventions.Put))]
        public IActionResult Put(Hobby hobby)
        {
            return Ok();
        }

        [HttpPost]
        [ApiConventionMethod(typeof(DefaultApiConventions),
        nameof(DefaultApiConventions.Post))]
        public IActionResult pOST(Hobby hobby)
        {
            return Ok();
        }

        [HttpDelete]
        [ApiConventionMethod(typeof(DefaultApiConventions),
        nameof(DefaultApiConventions.Delete))]
        public IActionResult Delete(int id)
        {
            return Ok();
        }

    }
}
