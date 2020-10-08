using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using lab1.Models;

namespace lab1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.ShowCurrentData = DateTime.Now;

            return View();
        }
     
       

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {
            return RedirectToAction("Redirect");
        }

        public IActionResult Redirect()
        {
            return View();
        }
        public IActionResult GetJson()
        {
            return Json(new { foo = "bar", baz = "Blech" });
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
