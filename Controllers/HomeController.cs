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
        public IActionResult Details(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var content = PopularMoviesRepo.Popmov.FirstOrDefault(i => i.id == id);
            if(content == null)
            {
                return NotFound();
            }
            return View(content);
        }
    }



}