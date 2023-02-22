using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission6_eg439.Models;
using System.Linq;


namespace Mission6_eg439.Controllers
{
    public class HomeController : Controller
    {

        private MovieContext blahContext { get; set; }

        // Constructor
        public HomeController( MovieContext someName)
        {
            blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieInput()
        {
            ViewBag.Categories = blahContext.Categories.ToList();
            return View(); // return view(new Movie());
        }

        [HttpPost]
        public IActionResult MovieInput(Movie response)
        {
            if (ModelState.IsValid)
            {
                blahContext.Add(response);
                blahContext.SaveChanges();
                return View("Confirmation", response);
            }
            else //if invalid
            {
                ViewBag.Categories = blahContext.Categories.ToList();
                return View();
            }
        }
        public IActionResult Podcasts()
        {
            return View("Podcasts");
        }
        [HttpGet]
        public IActionResult Movies()
        {

            var movieList = blahContext.responses.Include(x=> x.Category).OrderBy(x => x.Title).ToList();
            return View(movieList);
        }

        [HttpGet]
        public IActionResult Edit(int MovieId)
        {
            ViewBag.Categories = blahContext.Categories.ToList();

            var movie = blahContext.responses.Single(x => x.MovieId == MovieId);

            return View("MovieInput", movie);
        }

        [HttpPost]
        public IActionResult Edit(Movie blah)
        {
            blahContext.Update(blah);
            blahContext.SaveChanges();
            return RedirectToAction("Movies");
        }
        [HttpGet]
        public IActionResult Delete(int MovieId)
        { 
            var movie = blahContext.responses.Single(x => x.MovieId == MovieId);

            return View(movie);
        }
        [HttpPost]
        public IActionResult Delete(Movie Response)
        {
            blahContext.responses.Remove(Response);
            blahContext.SaveChanges();
            return RedirectToAction("Movies");
        }
    }
}
