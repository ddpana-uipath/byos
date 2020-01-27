using Byos.Models;
using Byos.ViewModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NUnit.Framework.Internal;
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
        [AllowAnonymous]
        public ActionResult Index()
        {
            ViewBag.Title = "BYOS";
            ViewBag.AppTitle = "BYOS";
            return View();
        }
    }
}