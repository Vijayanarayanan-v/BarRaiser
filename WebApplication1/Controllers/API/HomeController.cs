using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;
using System.Data;


namespace WebApplication1.Controllers.API
{
    [RoutePrefix("api/Home")]
    public class HomeController : ApiController
    {
        [HttpGet]
        [Route("getid")]
        public IHttpActionResult getvalue() {

              return Ok();        
        }
    }
}
