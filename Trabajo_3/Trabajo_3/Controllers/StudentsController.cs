using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

namespace Trabajo_3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IConfiguration _config;
        public StudentsController(IConfiguration config)
        {
            _config = config;
        }
        [HttpGet]
        public List<Student> GetStudent()
        {
            return new List<Student>() {
            new Student() { NameStudent = $"Daniel " },
            new Student() { NameStudent = $"Camila" },
            new Student() { NameStudent = $"Adrian" }
            };
        }
        [HttpPost]
        public Student CreateStudent([FromBody] string studentName)
        {
            return new Student()
            {
                NameStudent = studentName
            };
        }
    }
}
