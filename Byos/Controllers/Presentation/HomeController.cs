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
        public ActionResult Index()
        {
            ViewBag.Title = "Homepage";
            return View();
        }
        public string Details(int id)
        {
            return "Test";
        }

    }
}