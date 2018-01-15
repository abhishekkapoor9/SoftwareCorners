using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoftwareCorners.Areas.CV.Controllers
{
    public class CVController : Controller
    {
        // GET: CV/CV
        public ActionResult Index()
        {
            return View();
        }
    }
}