using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodoWeb.repository;

namespace TodoWeb.Controllers
{
    public class HomeController : Controller
    {
        private ITodo ITodo;

       public HomeController() {
           // this.ITodo = _ITodo;

        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}