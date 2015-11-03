using ATM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace ATM.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        [Authorize]
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            var checkingAccountId = db.CheckingAccounts.Where(c => c.ApplicationUserId == userId).First().id;
            ViewBag.CheckingAccountId = checkingAccountId;
            return View();
        }
        [HttpGet]
        public ActionResult About()
        {
            ViewBag.TheMessage = "Left your message ";

            return View();
        }

        [HttpPost]
        public ActionResult About(string message)
        {
            ViewBag.TheMessage = "Thank you we will contact";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}