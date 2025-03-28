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

        public IActionResult Edit(int id) {
           var Student =  _context.tbl_students.Find(id);

            if (Student == null) {
                     return NotFound();
                    }

            return View(Student);
        }

        [HttpPost]
        public IActionResult Edit(Student std) {

            if (ModelState.IsValid) {
                _context.tbl_students.Update(std);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(std);
        }

        public IActionResult Delete(int id) {

            var student = _context.tbl_students.Find(id);
            if (student == null) {
                return NotFound();
            }

            _context.tbl_students.Remove(student);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
