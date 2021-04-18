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
    [Route("teams")]
    public class TeamsController : ControllerBase
    {
        private ILogger<TeamsController> _logger;
        private TeamContext _ctx;
        public TeamsController(ILogger<TeamsController> logger, TeamContext ctx)
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
                return Ok(_ctx.Teams.Take(5).ToList());
            var team = _ctx.Teams.Find(id);
            if (team == null)
                return NotFound();
            
            return Ok(team);
        }

        [HttpPut]
        [ApiConventionMethod(typeof(DefaultApiConventions),
        nameof(DefaultApiConventions.Put))]
        public IActionResult Put(Team team)
        {
            return Ok();
        }

        [HttpPost]
        [ApiConventionMethod(typeof(DefaultApiConventions),
        nameof(DefaultApiConventions.Post))]
        public IActionResult pOST(Team team)
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
