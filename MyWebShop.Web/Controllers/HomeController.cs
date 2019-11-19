using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebShop.Web.Controllers
{
    [RoutePrefix("Start")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Route("Kapcsolat/{number?}")]
        public ActionResult Contact(int? number)
        {
            ViewData["Cica"] = "Cirmi";
            ViewBag.Message = "Your contact page.";

            // Actionmethodok közötti adatok továbbítására
            TempData["Kutya"] = "Buksi";


            return View(new Contact
            {
                Address = "Győr, Vasvári Pál u. 1/c",
                Phone = "+ 36 123 456"
            });
        }
    }

    public class Contact
    {
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}