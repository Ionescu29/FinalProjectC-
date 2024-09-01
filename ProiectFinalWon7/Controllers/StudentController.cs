using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProiectFinalWon7.Data;
using ProiectFinalWon7.DTO;
using ProiectFinalWon7.Models;
using ProiectFinalWon7.Services;

namespace ProiectFinalWon7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentServices studentServices;
        public StudentController(StudentServices studentServices)
        {
            this.studentServices = studentServices;
        }
        //aici in controller chemam metodele
        [HttpPost]
        public Student AddStudent([FromBody] StudentToCreateDTO studentToCreate) =>
            studentServices.AddStudent(studentToCreate.Name, studentToCreate.LastName, studentToCreate.Age);
        [HttpGet]
        public List<Student> GetAll() =>
            studentServices.GetAll();
        [HttpPost]
        public Student GetStudentById(Guid Id) =>
            studentServices.GetStudentById(Id);
        [HttpPost]
        public Student DeleteStudentByName(string Name) =>
            studentServices.DeleteStudentByName(Name);
    }
    
    
}
