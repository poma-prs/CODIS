using System;
using System.Collections.Generic;
using System.Net;
using Archive.API.Models;
using Microsoft.AspNet.Mvc;
using Swashbuckle.SwaggerGen.Annotations;

namespace Archive.API.Controllers
{
    [Route("api/[controller]")]
    public class ProblemsController : Controller
    {
        [HttpGet("collections/{id}")]
        [SwaggerOperation("GetCollection")]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(ICollection<Problem>))]
        public IActionResult GetCollection(long id)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}/statement/url")]
        [SwaggerOperation("GetStatementUrl")]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(string))]
        public IActionResult GetStatementUrl(long id)
        {
            throw new NotImplementedException();
        }
    }
}
