using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public  IActionResult GetAllStudent()
        {
            String[] StudentsName = new String[] {  "saamd", "ali", "aslam", "sssad" };
            return Ok(StudentsName);
        }
    }
}
