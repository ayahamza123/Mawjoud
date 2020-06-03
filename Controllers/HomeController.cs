using Mawjoud2.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mawjoud2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string search,int? page )
        {
            HomeIndexmodel model = new HomeIndexmodel();
            return View(model.CreateModel(search,10,page));
        }
        [Authorize]
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