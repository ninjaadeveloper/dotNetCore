using DatabaseApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseApp.Controllers
{
    public class ProductController : Controller
    {
        private IWebHostEnvironment _env;
        private myContext _context;
        public ProductController(IWebHostEnvironment env,myContext context) { 
            _env = env;
            _context = context;
        }
        public IActionResult Index()
        {
           var products =  _context.tbl_product.ToList();
            return View(products);
        }

        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        public IActionResult Create(IFormFile prodImage,Product prod)
        {
            //move uploaded file into server
            string fileName = Path.GetFileName(prodImage.FileName);
            string filePath = Path.Combine(_env.WebRootPath, "uploads", fileName);
             FileStream fs = new FileStream(filePath, FileMode.Create);
            prodImage.CopyTo(fs);

            // upload in database

            prod.prodImage = fileName;
            _context.tbl_product.Add(prod);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
