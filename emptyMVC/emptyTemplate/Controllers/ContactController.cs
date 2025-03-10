using Microsoft.AspNetCore.Mvc;

namespace emptyTemplate.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
