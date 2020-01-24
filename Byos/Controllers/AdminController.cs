using Byos.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Byos.Controllers
{
    public class AdminController : Controller
    {
        public AdminController()
        {

        }
        public ActionResult Index()
        {
            ViewBag.Title = "Admin Home";
            return View();
        }
    }
}
