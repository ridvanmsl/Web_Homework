using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;

namespace WebAssignmentt.Controllers
{
    public class About : Controller
    {
        public IActionResult about()
        {
            return View("~/Views/Home/movies/about.cshtml");
        }
    }
}
