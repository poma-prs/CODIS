using System;
using System.Collections.Generic;
using System.Net;
using Checking.API.Models;
using Microsoft.AspNet.Mvc;
using Swashbuckle.SwaggerGen.Annotations;

namespace Checking.API.Controllers
{
    [Route("api/[controller]")]
    public class SubmitsController : Controller
    {
        [HttpPost("send")]
        [SwaggerOperation("send")]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(ICollection<long>))]
        public IActionResult Send([FromBody] Submit submit)
        {
            throw new NotImplementedException();
        }

        [HttpPost("rejudge")]
        [SwaggerOperation("rejudge")]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(ICollection<long>))]
        public IActionResult Rejudge([FromBody] string ids)
        {
            throw new NotImplementedException();
        }
    }
}
