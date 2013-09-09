using System;
using System.Web.Mvc;
using PayboardApiTest.Models;

namespace PayboardApiTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new HomeIndexModel
            {
                CustomerId = Guid.NewGuid().ToString(),
                CustomerName = Guid.NewGuid().ToString(),
                CustomerUserEmail = Guid.NewGuid() + "@gmail.com",
                CustomerUserName = Guid.NewGuid().ToString()
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