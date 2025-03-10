using Microsoft.AspNetCore.Mvc;
using ModelApp.Models;

namespace ModelApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            //StudentModel model = new StudentModel();
            var studentModels = new List<StudentModel>
            {
                new StudentModel { Id=1,Name= "Mudassir",Batch = "PR2-202311B",Email="mudassir@gmail.com" },

                new StudentModel {  Id = 2, Name="Touqeer",Batch = "PR2-202311B",Email="touqeer@gmail.com" },

                  new StudentModel {  Id = 3, Name="Yawar",Batch = "PR2-202311B",Email="yawar@gmail.com" }

            };
            //ViewBag.Students = studentModels;
            ViewData["students"] = studentModels;
            return View();
        }
    }
}
