using Microsoft.AspNetCore.Mvc;

namespace emptyTemplate.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
