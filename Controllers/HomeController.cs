using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAssignmentt.Models;

namespace WebAssignmentt.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(PopularMoviesRepo.Popmov);
        }
        [HttpPost("Details")]
        public IActionResult Details(string filmurl)
        {
            string url = "~/Views/Home/movies/";
            string newurl = string.Concat(url, filmurl);
            return Content(newurl);
        }
    }
}