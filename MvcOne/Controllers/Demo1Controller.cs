using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOne.Controllers
{
    public class Demo1Controller : Controller
    {
        // GET: Demo1
        public ActionResult Index()
        {
            return View();
        }
    }
}