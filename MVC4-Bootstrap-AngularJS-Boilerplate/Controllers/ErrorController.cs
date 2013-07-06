using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC4_Bootstrap_AngularJS_Boilerplate.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult General()
        {
            return View();
        }

        public ActionResult NotFound()
        {
            return View();
        }
    }
}
