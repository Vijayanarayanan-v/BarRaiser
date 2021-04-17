using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Net;
using MVCclass = System.Web.Mvc;
using HttpPostAttribute = System.Web.Mvc.HttpPostAttribute;
using System.Web.Mvc;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;

namespace WebApplication1.Controllers
{   [System.Web.Mvc.AllowAnonymous]
    [System.Web.Mvc.RoutePrefix("Home")]
    public class HomeController : Controller
    {
        // GET: Home
        
        public ActionResult Index()
        {
            return View();
        }

       
    }
}