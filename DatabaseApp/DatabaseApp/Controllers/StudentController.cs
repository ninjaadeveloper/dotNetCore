using DatabaseApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseApp.Controllers
{
    public class StudentController : Controller
    {
        private myContext _context;
        public StudentController(myContext context) {
        
            _context = context;
        
        }

        public IActionResult Index()
        {
           var students = _context.tbl_students.ToList();
            return View(students);
        }

        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student std)
        {
            if (ModelState.IsValid)
            {
                _context.Add(std);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else {
                return View();
            }
        }
    }
}
