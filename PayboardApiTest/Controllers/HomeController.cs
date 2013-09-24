using System;
using System.Web.Mvc;
using PayboardApiTest.Helpers;
using PayboardApiTest.Models;

namespace PayboardApiTest.Controllers
{
    public class HomeController : Controller
    {
        private const string prefix = "_PBAPITest_";

        public ActionResult Index()
        {
            var model = new HomeIndexModel
            {
                CustomerId = prefix + ShortGuid.NewGuid(),
                CustomerName = prefix + ShortGuid.NewGuid(),
                CustomerUserEmail = prefix + ShortGuid.NewGuid() + "@gmail.com",
                CustomerUserId = prefix + ShortGuid.NewGuid(),
                CustomerUserName = prefix + ShortGuid.NewGuid()
            };
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            var model = new HomeIndexModel
            {
                CustomerId = prefix + ShortGuid.NewGuid(),
                CustomerName = prefix + ShortGuid.NewGuid(),
                CustomerUserEmail = prefix + ShortGuid.NewGuid() + "@gmail.com",
                CustomerUserId = prefix + ShortGuid.NewGuid(),
                CustomerUserName = prefix + ShortGuid.NewGuid()
            };
            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}