using System;
using System.Collections.Generic;
using System.Net;
using Checking.API.Models;
using Microsoft.AspNet.Mvc;
using Swashbuckle.SwaggerGen.Annotations;

namespace Checking.API.Controllers
{
    [Route("api/[controller]")]
    public class ResultsController : Controller
    {
        [HttpGet]
        [SwaggerOperation("get")]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(ICollection<SubmitResult>))]
        public IActionResult Get(string ids)
        {
            throw new NotImplementedException();
        }
    }
}
