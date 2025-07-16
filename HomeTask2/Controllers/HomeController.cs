
using Microsoft.AspNetCore.Mvc;
using HomeTask2.Models;

namespace HomeTask2.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class HomeController : Controller
    {
        public static List<Student> Students { get; set; } = new List<Student>()
        {
            new Student()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Score = 6.5,
                Phone = "0888888888"
            },
            new Student()
            {
                Id = 2,
                FirstName = "Alex",
                LastName = "Bill",
                Score = 8.5,
                Phone = "1234567890",
            },
            new Student()
            {
                Id = 3,
                FirstName = "Mustafo",
                LastName = "Ravshanov",
                Score = 10,
                Phone = "7777777777"
            }
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Students);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Student student)
        {
            Students.Add(student);
            
            return Created(); 
        }

        [HttpPut]
        public IActionResult Put([FromBody] Student student)
        {
            Student maybeStudent= Students.FirstOrDefault(storageStudent => storageStudent.Id == student.Id);
            if (maybeStudent == null)
            {
                return NotFound();
            } 
            maybeStudent.FirstName=student.FirstName ;
            maybeStudent.LastName=student.LastName ;
            maybeStudent.Score=student.Score ;
            maybeStudent.Phone=student.Phone ;
            
            return Ok(maybeStudent);
        }

        [HttpDelete("{studentId}")]
        public IActionResult Delete(int studentId)
        {
            Student maybeStudent= Students.FirstOrDefault(storageStudent => storageStudent.Id == studentId);
            if (maybeStudent == null)
            {
                return NotFound();
            } 
            
            Students.Remove(maybeStudent); 
            return Ok(maybeStudent );
        }
    }
}