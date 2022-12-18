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
        public IActionResult Details()
        {
            return View("/movies/doctor-strange.cshtml");
        }
    }
}