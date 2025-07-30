using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UsersApplication.Models;

namespace UsersApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserDBContext dBContext;
        IWebHostEnvironment env;

        public HomeController(UserDBContext dBContext, IWebHostEnvironment env)
        {
            this.dBContext = dBContext;
            this.env = env;
        }

        public IActionResult Index()
        {

            var students = dBContext.Students
                             .Include(s => s.Course) // Join with Course
                             .ToList();

            return View(students);
        }

        public IActionResult Create() {
            var courses = dBContext.Courses.ToList();
            ViewBag.CourseList = new SelectList(courses, "Id", "CourseName");
            return View();
        }

       [HttpPost]
       [ValidateAntiForgeryToken]
        public IActionResult Create(Student std, IFormFile image)
        {
            if (ModelState.IsValid)
            {

                string fileName = Path.GetFileName(image.FileName);
                string filePath = Path.Combine(env.WebRootPath, "images", fileName);
                FileStream fs = new FileStream(filePath, FileMode.Create);
                image.CopyTo(fs);

                std.image = fileName;
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

            var courses = dBContext.Courses.ToList();
            ViewBag.CourseList = new SelectList(courses, "Id", "CourseName", student.CourseId);

            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(Student std, IFormFile image)
        {


            if (image != null)
            {
                string fileName = Path.GetFileName(image.FileName);
                string filePath = Path.Combine(env.WebRootPath, "images", fileName);
                FileStream fs = new FileStream(filePath, FileMode.Create);
                image.CopyTo(fs);
                std.image = fileName;
            }
            else
            {

                var existingstudent = dBContext.Students.Find(std.Id);
                std.image = existingstudent.image;
            }

            dBContext.Students.Update(std);
            dBContext.SaveChanges();
            return RedirectToAction("Index", "Home");
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
