using CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace CRUD.Controllers
{
    public class AdminController : Controller
    {
        private readonly eCommerceContext DbContext;
        private readonly IWebHostEnvironment env;

        public AdminController(eCommerceContext NewContext, IWebHostEnvironment newenv)
        {
            this.DbContext = NewContext;
            this.env = newenv;
        }

        public IActionResult Index()
        {
            var products = DbContext.tbl_products.Count();
            var categories = DbContext.tbl_categories.Count();
            ViewBag.product_count = products;
            ViewBag.category_count = categories;
            return View();
        }

        public IActionResult Product() {

            //var products = DbContext.tbl_products.ToList();
            var products = DbContext.tbl_products.Include(p => p.Category).ToList();
            return View(products);
        }

        public IActionResult Create()
        {
            var categories = DbContext.tbl_categories.ToList();
            ViewBag.categoryData = new SelectList(categories,"id", "catname");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product prod, IFormFile image)
        {
            //return image;
            string filename = Path.GetFileName(image.FileName); //to get filename
            string path = Path.Combine(env.WebRootPath, "images", filename); //to get path
            FileStream fs = new FileStream(path,FileMode.Create); // to move images / file
            image.CopyTo(fs);

            prod.image = filename;
            DbContext.tbl_products.Add(prod);
            DbContext.SaveChanges();
            TempData["success"] = "Product has been added successfully";
            return RedirectToAction("Product", "Admin");
        }

        public IActionResult Edit(Guid id) {


            var products = DbContext.tbl_products.Find(id);
            var categories = DbContext.tbl_categories.ToList();
            ViewBag.categoryData = new SelectList(categories, "id", "catname", products.CategoryId);
            return View(products);

        }

        [HttpPost]
        public IActionResult Edit(Product prod,IFormFile image,Guid id)
        {
            if (image != null)
            {
                //return image;
                string filename = Path.GetFileName(image.FileName); //to get filename
                string path = Path.Combine(env.WebRootPath, "images", filename); //to get path
                FileStream fs = new FileStream(path, FileMode.Create); // to move images / file
                image.CopyTo(fs);
                prod.image = filename;
            }
            else {
                //var products = DbContext.tbl_products.Find(id);
                var products = DbContext.tbl_products.AsNoTracking().FirstOrDefault(myproduct => myproduct.id == prod.id);
                prod.image = products.image;
            }


            DbContext.tbl_products.Update(prod);
            DbContext.SaveChanges();
            return RedirectToAction("Product", "Admin");

        }

        public IActionResult Preview(Guid id) {

            var products = DbContext.tbl_products.Include(p => p.Category).FirstOrDefault(p => p.id == id);
            return View(products); 
        }

        public IActionResult Delete(Guid id)
        {
            var std = DbContext.tbl_products.Find(id);
            DbContext.tbl_products.Remove(std);
            DbContext.SaveChanges();
            return RedirectToAction("Product", "Admin");
        }

        public IActionResult Category()
        {

            var categories = DbContext.tbl_categories.ToList();
            return View(categories);
        }

        
        public IActionResult DeleteCategory(Guid id)
        {
            var category = DbContext.tbl_categories.Find(id);
            bool isUsedInProducts = DbContext.tbl_products.Any(p => p.CategoryId == id);
            if (isUsedInProducts)
            {
                TempData["error"] = "This category is in use by one or more products and cannot be deleted.";
                return RedirectToAction("Category");
            }

            DbContext.tbl_categories.Remove(category);
            DbContext.SaveChanges();
            TempData["success"] = "Category has been deleted successfully.";
            return RedirectToAction("Category", "Admin");
        }

    }


}
