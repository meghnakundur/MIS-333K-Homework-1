using Microsoft.AspNetCore.Mvc;

namespace Kundur_Meghna_HW1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        public HomeController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        //TODO: Create a new action method for the new page
        public IActionResult Professional()
        {
            return View();
        }

        public IActionResult Resume()
        {
            string path = _environment.WebRootPath + "/files/Resume_Meghna Kundur1.pdf";
            var stream = new FileStream(path, FileMode.Open);
            return File(stream, "application/pdf", "Resume_Meghna Kundur1.pdf");
        }
    }
}
