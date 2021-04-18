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
    [Route("stadium")]
    public class StadiumsController : ControllerBase
    {
        private ILogger<StadiumsController> _logger;
        private TeamContext _ctx;
        public StadiumsController(ILogger<StadiumsController> logger, TeamContext ctx)
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
                return Ok(_ctx.Stadiums.Take(5).ToList());
            var stadium = _ctx.Stadiums.Find(id);
            if (stadium == null)
                return NotFound();
            
            return Ok(stadium);
        }

        [HttpPut]
        [ApiConventionMethod(typeof(DefaultApiConventions),
        nameof(DefaultApiConventions.Put))]
        public IActionResult Put(Stadium stadium)
        {
            return Ok();
        }

        [HttpPost]
        [ApiConventionMethod(typeof(DefaultApiConventions),
        nameof(DefaultApiConventions.Post))]
        public IActionResult pOST(Stadium stadium)
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
