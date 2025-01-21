using Microsoft.AspNetCore.Mvc;

namespace prac_1.Controllers
{
    public class MenController : Controller
    {
        public string test() {
            return "this is a testing method";
            
        }
        public IActionResult jeans()
        {
            return View();
            
        }

        public IActionResult kurta()
        {
            return View();

        }
    }
}
