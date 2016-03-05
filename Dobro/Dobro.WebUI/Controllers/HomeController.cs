using Dobro.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dobro.WebUI.Models;
using Dobro.Domain.Concrete;

namespace Dobro.WebUI.Controllers
{
    public class HomeController : Controller
    {

        private IDoingRepository DoingRepository;

        public HomeController(IDoingRepository repoParam)
        {
            DoingRepository = repoParam; //конструктор для Ninject
        }

        public ActionResult Index()
        {
            return View(DoingRepository.Doings);
        }
    }
}