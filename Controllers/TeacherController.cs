using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllTeacher()
        {
            String[] TeachersName = new String[] { "abc", "ali", "aslam", "sssad" };
            return Ok(TeachersName);
        }
    }
}
