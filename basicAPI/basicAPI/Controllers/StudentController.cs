using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace basicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public List<string> students = new List<string>() {
        "Osama",
        "Ali",
        "Zubair"
        };

        [HttpGet]
        public List<string> GetStudents()
        {
            return students;
        }

        [HttpGet("id")]
        public string GetStudentDetail(int id)
        {
            return students[id];
        }
    }
}
