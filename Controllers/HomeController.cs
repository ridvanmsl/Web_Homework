using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAssignmentt.Models;

namespace WebAssignmentt.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
<<<<<<< Updated upstream
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
=======

        //public IActionResult Films(int idd)
        //{
        //    var s = PopularMoviesRepo.Popmov;
        //    string ss= "";
        //    foreach(var item in s)
        //    {
        //        if(item.id == idd)
        //        {
        //           //ss = item.view_url;
        //        }
        //    }

        //    return View();
        //}

        

>>>>>>> Stashed changes
    }



}