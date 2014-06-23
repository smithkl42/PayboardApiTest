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
            var model = new CustomerUserModel
            {
                CustomerId = prefix + ShortGuid.NewGuid(),
                CustomerName = prefix + ShortGuid.NewGuid(),
                CustomerUserEmail = prefix + ShortGuid.NewGuid() + "@gmail.com",
                CustomerUserId = prefix + ShortGuid.NewGuid(),
                CustomerUserFirstName = prefix + ShortGuid.NewGuid(),
                CustomerUserLastName = prefix + ShortGuid.NewGuid()
            };
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            var model = new CustomerUserModel
            {
                CustomerId = prefix + ShortGuid.NewGuid(),
                CustomerName = prefix + ShortGuid.NewGuid(),
                CustomerUserEmail = prefix + ShortGuid.NewGuid() + "@gmail.com",
                CustomerUserId = prefix + ShortGuid.NewGuid(),
                CustomerUserFirstName = prefix + ShortGuid.NewGuid(),
                CustomerUserLastName = prefix + ShortGuid.NewGuid()
            };
            return View(model);
        }

        public ActionResult ZeroConfig()
        {
            ViewBag.Message = "A page to test the ZeroConfig scripts.";
            var model = new CustomerUserModel
            {
                CustomerId = prefix + ShortGuid.NewGuid(),
                CustomerName = prefix + ShortGuid.NewGuid(),
                CustomerUserEmail = prefix + ShortGuid.NewGuid() + "@gmail.com",
                CustomerUserId = prefix + ShortGuid.NewGuid(),
                CustomerUserFirstName = prefix + ShortGuid.NewGuid(),
                CustomerUserLastName = prefix + ShortGuid.NewGuid()
            };
            return View(model);
        }

        public ActionResult Slider()
        {
            ViewBag.Message = "A page to test the Slider script.";
            return View();
        }

        [HttpPost]
        public ActionResult ZeroConfig(CustomerUserModel model)
        {
            return View(model);
        }
    }
}