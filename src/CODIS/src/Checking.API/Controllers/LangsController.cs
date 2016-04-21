using System;
using System.Collections.Generic;
using System.Net;
using Checking.API.Models;
using Microsoft.AspNet.Mvc;
using Swashbuckle.SwaggerGen.Annotations;

namespace Checking.API.Controllers
{
    [Route("api/[controller]")]
    public class LangsController : Controller
    {
        [HttpGet]
        [SwaggerOperation("get")]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(ICollection<Language>))]
        public IActionResult Get()
        {
            throw new NotImplementedException();
        }
    }
}
