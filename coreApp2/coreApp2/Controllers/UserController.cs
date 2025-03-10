using Microsoft.AspNetCore.Mvc;

namespace coreApp2.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public string Username(string id) {
            return "Your name is " + id;
        }
    }
}
