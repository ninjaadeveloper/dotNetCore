using DatabaseApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        public IActionResult Show(int id) {
            var singleProduct = _context.tbl_product.Find(id);
            return View(singleProduct);
        }

        public IActionResult Edit(int id) {
            var editProdict = _context.tbl_product.Find(id);
            return View(editProdict);
        }

        [HttpPost]
        public IActionResult Edit(Product prod,IFormFile prodImage) {

            if (prodImage == null)
            {
                var extistingProduct = _context.tbl_product.AsNoTracking().FirstOrDefault(p => p.Id == prod.Id);

                prod.prodImage = extistingProduct.prodImage;
            }
            else {
                //move uploaded file into server
                string fileName = Path.GetFileName(prodImage.FileName);
                string filePath = Path.Combine(_env.WebRootPath, "uploads", fileName);
                FileStream fs = new FileStream(filePath, FileMode.Create);
                prodImage.CopyTo(fs);

                prod.prodImage = fileName;
            }

            _context.tbl_product.Update(prod);
            _context.SaveChanges();
            return RedirectToAction("Index");
            
        }

        public IActionResult Delete(int id) {

           var deleteProduct =  _context.tbl_product.Find(id);
            _context.tbl_product.Remove(deleteProduct);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
