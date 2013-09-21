using System;
using System.Web.Mvc;
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
                CustomerId = prefix + Guid.NewGuid(),
                CustomerName = prefix + Guid.NewGuid(),
                CustomerUserEmail = prefix + Guid.NewGuid() + "@gmail.com",
                CustomerUserId = prefix + Guid.NewGuid(),
                CustomerUserName = prefix + Guid.NewGuid()
            };
            return View(model);
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