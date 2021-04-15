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
    public class CoachesController : ControllerBase
    {
        private ILogger<CoachesController> _logger;
        private TeamContext _ctx;
        public CoachesController(ILogger<CoachesController> logger, TeamContext ctx)
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
                return Ok(_ctx.Coaches.Take(5).ToList());
            var coach = _ctx.Coaches.Find(id);
            if (coach == null)
                return NotFound();
            
            return Ok(coach);
        }

        [HttpPut]
        [ApiConventionMethod(typeof(DefaultApiConventions),
        nameof(DefaultApiConventions.Put))]
        public IActionResult Put(Coach coach)
        {
            return Ok();
        }

        [HttpPost]
        [ApiConventionMethod(typeof(DefaultApiConventions),
        nameof(DefaultApiConventions.Post))]
        public IActionResult pOST(Coach coach)
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
