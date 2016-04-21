using System;
using System.Collections.Generic;
using System.Net;
using CODIS.API.Models;
using Microsoft.AspNet.Mvc;
using Swashbuckle.SwaggerGen.Annotations;

namespace CODIS.API.Controllers
{
    [Route("api/[controller]")]
    public class ResultsController : Controller
    {
        [HttpGet]
        [SwaggerOperation("get")]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(ICollection<SubmitResultModel>))]
        public IActionResult Get(string ids)
        {
            throw new NotImplementedException();
        }
    }
}
