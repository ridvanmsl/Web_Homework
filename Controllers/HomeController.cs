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
        [HttpPost]
        public IActionResult Details(string filmurl)
        {
            string url = "~/Views/Home/movies/" + filmurl;
            return View(url);
        }
    }
}