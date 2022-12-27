using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;
using WebAssignmentt.Models;

namespace WebAssignmentt.Controllers
{
    public class AboutController : Controller
    {
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(string name)
        {
            ViewBag.Name = name;
            return View("Show");
        }
    }
}
