using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dobro.WebUI.Controllers
{
    public class DoingController : Controller
    {
        // GET: Doing
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Choose(int? id) { 
            return View(id);

        }
    }
}