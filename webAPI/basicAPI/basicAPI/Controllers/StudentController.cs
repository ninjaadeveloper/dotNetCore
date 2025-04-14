using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace basicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public List<string> studentList = new List<string>()
        {
            "Zaki",
            "Hamza Akram",
            "Suleman",
            "Mudassir",
            "Jazib Salman",
            "Sami",
            "Touqeer",
            "Yawar"
        };

        [HttpGet]
        public List<string> Students() {
            return studentList;
        }

        [HttpGet("id")]
        public string StudentDetail(int id) {
            return studentList[id];
        }

    }
}
