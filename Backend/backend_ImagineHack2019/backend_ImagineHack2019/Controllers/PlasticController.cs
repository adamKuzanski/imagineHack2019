using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend_ImagineHack2019.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend_ImagineHack2019.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlasticController : ControllerBase
    {
        private readonly IDatabaseService _databaseService;
        public PlasticController(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }


        // GET api/plastic/test
        [HttpGet("test")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok("Hello World");
        }

        [HttpGet("addPlastic")]
        public ActionResult<IEnumerable<string>> AddPlastic()
        {
            return Ok("Hello World");
        }


    }
}