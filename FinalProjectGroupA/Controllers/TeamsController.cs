using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FinalProjectGroupA.Data;

namespace FinalProjectGroupA.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamsController
    {
        private ILogger<TeamsController> _logger;
        private TeamContext _ctx;
        public TeamsController(ILogger<TeamsController> logger, TeamContext ctx)
        {
            _logger = logger;
            _ctx = ctx;
        }

    }
}
