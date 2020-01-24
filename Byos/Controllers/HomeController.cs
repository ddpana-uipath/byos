using Byos.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Byos.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        [Route("~/")]
        [Route("~/index")]
        [Route("~/home")]
        public ActionResult Index()
        {
            ViewBag.Title = "BYOS";
            ViewBag.AppTitle = "BYOS";
            return View();
        }

        [Route("~/login")]
        [HttpGet]
        public ActionResult Login()
        {
            ViewBag.AppTitle = "BYOS";
            return View();
        }

        [Route("~/login")]
        [HttpPost]
        public string PostLogin()
        {
            ViewBag.AppTitle = "BYOS";
            return "Test";
        }

        [Route("~/register")]
        public ActionResult Register()
        {
            ViewBag.AppTitle = "BYOS";
            return View();
        }

        [Route("~/forgot-password")]
        public ActionResult ForgotPassword()
        {
            ViewBag.AppTitle = "BYOS";
            return View();
        }

    }
}