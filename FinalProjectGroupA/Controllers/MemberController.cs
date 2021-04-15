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
    public class MembersController : ControllerBase
    {
        private ILogger<MembersController> _logger;
        private TeamContext _ctx;
        public MembersController(ILogger<MembersController> logger, TeamContext ctx)
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
                return Ok(_ctx.Members.Take(5).ToList());
            var member = _ctx.Members.Find(id);
            if (member == null)
                return NotFound();
            
            return Ok(member);
        }

        [HttpPut]
        [ApiConventionMethod(typeof(DefaultApiConventions),
        nameof(DefaultApiConventions.Put))]
        public IActionResult Put(Member member)
        {
            return Ok();
        }

        [HttpPost]
        [ApiConventionMethod(typeof(DefaultApiConventions),
        nameof(DefaultApiConventions.Post))]
        public IActionResult pOST(Member member)
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
