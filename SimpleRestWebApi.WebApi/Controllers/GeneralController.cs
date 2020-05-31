using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

        [HttpGet]
        [Route("getSortedData")]
        public IActionResult GetSortedData()
        {
            List<int> lstData = null;
            Random random = new Random(1000);
                  
            for (var counter =0; counter < 100; counter++)
            {
                lstData =   new List<int>();
                lstData.Add(random.Next());
            }
            if (lstData != null)
            {
                lstData.Sort();
            }
            return Ok(lstData);
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
