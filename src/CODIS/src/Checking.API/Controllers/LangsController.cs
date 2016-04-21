using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.AspNet.Mvc;
using Swashbuckle.SwaggerGen.Annotations;

namespace Checking.API.Controllers
{
    [Route("api/[controller]")]
    public class LangsController : Controller
    {
        [HttpGet]
        [SwaggerOperation("get")]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(ICollection<string>))]
        public IActionResult Get()
        {
            throw new NotImplementedException();
        }
    }
}
