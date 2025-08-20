using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTRY.Models;   

namespace WebTRY.Controllers
{
    public class LandingPageController : Controller
    {
        // Landing Page
        public ActionResult Index()
        {
            ViewBag.HeadT = "Welcome to Bastion Incorporation!";
            ViewBag.SubT = "We’re thrilled to have you join our team as an intern! To get started and complete your onboarding, please register by clicking the button below. If you’ve already registered, simply scan your QR code to continue.";
            return View();
        }

        // Show Registration Form (GET)
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        // Handle Registration Form (POST)
        [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
            return View(model);
        }

        public ActionResult QR()
        {
            return View();
        }

        public ActionResult Success()
        {
            return View();
        }
    }
}
