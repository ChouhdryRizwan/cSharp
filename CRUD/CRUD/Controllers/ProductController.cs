using CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Controllers
{
    public class ProductController : Controller
    {
        private  IWebHostEnvironment _env;
        private myContext _context;
        public ProductController(IWebHostEnvironment env, myContext context) {
            _env = env;
            _context = context;
        }
        public IActionResult Index()
        {
            var products = _context.tbl_Products.ToList();
            return View(products);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(IFormFile prodImage, Product prod)
        {
            string fileName = Path.GetFileName(prodImage.FileName);
            string filePath = Path.Combine(_env.WebRootPath,"images", fileName);
            FileStream fs = new FileStream(filePath, FileMode.Create);
            prodImage.CopyTo(fs);

            prod.prodImage = fileName;
            _context.tbl_Products.Add(prod);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var product = _context.tbl_Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(IFormFile prodImage, Product prod)
        {
            if (prodImage != null)
            {
                string fileName = Path.GetFileName(prodImage.FileName);
                string filePath = Path.Combine(_env.WebRootPath, "images", fileName);
                FileStream fs = new FileStream(filePath, FileMode.Create);
                prodImage.CopyTo(fs);
               
                prod.prodImage = fileName;
            }
            else
            {
                var existingProduct = _context.tbl_Products.AsNoTracking().FirstOrDefault(p => p.Id == prod.Id);
                if (existingProduct != null)
                {
                    prod.prodImage = existingProduct.prodImage;
                }
            }
            _context.tbl_Products.Update(prod);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult Delete(int id)
        {
            var product = _context.tbl_Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.tbl_Products.Remove(product);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
