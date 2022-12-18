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
        //[Route("/Home/movies",Name ="movie")]
        //public IActionResult Details(string movie)
        //{

        //    string url = "~/Views/Home/movies/" + movie;
        //    return Content(url);
        //}
        [Route("Home/{id:int}")]
        public IActionResult Detail(int idx) => View(PopularMoviesRepo.Popmov.FirstOrDefault(a => a.id == idx));
    }
}