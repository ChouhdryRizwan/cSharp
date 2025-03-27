using CRUD.Models;
using Microsoft.AspNetCore.Mvc;

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
            return View();
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(IFormFile img,Product prod)
        {
            string fileName = Path.GetFileName(img.FileName);
            string filePath = Path.Combine(_env.WebRootPath,"images", fileName);
            FileStream fs = new FileStream(filePath, FileMode.Create);
            img.CopyTo(fs);

            prod.prodImage = fileName;
            _context.tbl_Products.Add(prod);
            _context.SaveChanges();
            return View();
        }
    }
}
