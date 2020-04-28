using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lab16_1.Models;

namespace Lab16_1.Controllers
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
            return View();
        }

        [HttpGet]
        public IActionResult User() //sends the form back
        {
            //to pre-populate data field
            //use
            //Product p = new Product();
            //return View(p);

            return View();
        }

        [HttpPost]
        public IActionResult User(User u)
        {
            //put info into the DB here
            //can use data annotations etc in the model class
            //this is our final and safest check on the data
            //client-side validation tries to limit unnecessary server load
            //and the time the user has to wait for a response
            return View("UserSuccess", u);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
