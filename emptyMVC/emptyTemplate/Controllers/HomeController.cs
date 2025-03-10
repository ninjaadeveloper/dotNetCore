using Microsoft.AspNetCore.Mvc;

namespace emptyTemplate.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
