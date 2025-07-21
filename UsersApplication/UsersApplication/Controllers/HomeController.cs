using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UsersApplication.Models;

namespace UsersApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserDBContext dBContext;

        public HomeController(UserDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public IActionResult Index()
        {

            var students = dBContext.Students.ToList();
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
                dBContext.Students.Add(std);
                dBContext.SaveChanges();
                return RedirectToAction("Index","Home");
            }
            return View(std);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
