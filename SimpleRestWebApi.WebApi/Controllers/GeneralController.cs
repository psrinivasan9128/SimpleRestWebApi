using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleRestWebApi.WebApi.Models;

namespace SimpleRestWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GeneralController : ControllerBase
    {

        [HttpGet]
        [Route("getsum")]
        public ActionResult<string> GetSum(int x, int y)
        {
            return new string((x + y).ToString());
        }

        [HttpPost]
        [Route("getList")]
        public IActionResult GetListOfStudents([FromBody] Student student)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student
            {
                StudentName = "Ravi",
                Age = 33,
                Grade = "Dr"
            });

            if (student != null)
            {
                students.Add(student);
            }

            return Ok(students);
        }

       
    }
}
