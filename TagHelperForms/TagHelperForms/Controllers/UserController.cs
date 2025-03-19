using Microsoft.AspNetCore.Mvc;
using TagHelperForms.Models;

namespace TagHelperForms.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string Index(UserModel user)
        {
            return "User is " + user.Name + " email is " + user.Email + " batch code " + user.Batch + " and age is " + user.Age+" gender is " + user.Gender+ " and status is "+user.Married;
        }
    }
}
