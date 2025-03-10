using DataSharing.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DataSharing.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["message"] = "This is from viewData";
            ViewData["batch"] = "PR2-202311B";

            string[] students = { "Mudassir","Zaki","Hamza","Suleman","Jazib","SSami" };

            ViewBag.Name = "Mudassir";
            ViewBag.Names = students;
            return View();
        }

        public IActionResult Student() {

            List<string> courses = new  List<string>{ "ASP.NET", "C#", "Angular", "SQL" };

            ViewData["courseList"] = courses.ToArray();

            return View();
        }

        public IActionResult Privacy()
        {
            TempData["tData"] = "PR2-202411B";
            return View();
        }

        public int calculate() {

            return 2 + 2;
        
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
