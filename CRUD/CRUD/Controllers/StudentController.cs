using CRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
     public class StudentController : Controller
    {

        private myContext _context;
        public StudentController(myContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Student std)
        {
            if (ModelState.IsValid)
            {
                _context.tbl_Students.Add(std);
                _context.SaveChanges();
                return RedirectToAction("Fetch");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Fetch()
        {
            var students = _context.tbl_Students.ToList();
            return View(students);
        }

        public IActionResult Delete(int id)
        {
            var student = _context.tbl_Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }

            _context.tbl_Students.Remove(student);
            _context.SaveChanges();

            return RedirectToAction("Fetch");
        }

        public IActionResult Edit(int id)
        {
            var student = _context.tbl_Students.Find(id);
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
                _context.tbl_Students.Update(std);
                _context.SaveChanges();
                return RedirectToAction("Fetch");
            }
            return View(std);
        }
        public IActionResult Details(int id)
        {
            var student = _context.tbl_Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        
    }
}
