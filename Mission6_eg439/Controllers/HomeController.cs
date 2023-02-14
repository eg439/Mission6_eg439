using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission6_eg439.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_eg439.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieContext blahContext { get; set; }

        // Constructor
        public HomeController(ILogger<HomeController> logger, MovieContext someName)
        {
            _logger = logger;
            blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieInput()
        {
            return View("MovieInput");
        }

        [HttpPost]
        public IActionResult MovieInput(Movie response)
        {
            blahContext.Add(response);
            blahContext.SaveChanges();
            return View("Confirmation", response);
        }
        public IActionResult Podcasts()
        {
            return View("Podcasts");
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
