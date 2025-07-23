using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
       [ValidateAntiForgeryToken]
        public IActionResult Create(Student std)
        {
            if (ModelState.IsValid)
            {
                dBContext.Students.Add(std);
                dBContext.SaveChanges();
                TempData["success"] = "Data has been inserted sucessfully"; 
                return RedirectToAction("Index","Home");
            }
            return View(std);
        }

        public IActionResult Edit(int id)
        {

            var student = dBContext.Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(Student std)
        {

            if (ModelState.IsValid)
            {
                dBContext.Students.Update(std);
                dBContext.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(std);
        }

        public IActionResult Details(int id)
        {

            var student = dBContext.Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        public IActionResult Delete(int id)
        {

            var student = dBContext.Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }

            dBContext.Students.Remove(student);
            dBContext.SaveChanges();

            return RedirectToAction("Index", "Home");
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
