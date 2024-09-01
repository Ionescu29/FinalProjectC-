using Microsoft.AspNetCore.Mvc;
using ProiectFinalWon7.Data;
using ProiectFinalWon7.Models;
using System.Globalization;

namespace ProiectFinalWon7.Services
{
    public class StudentServices
    {
        private readonly RegistryStudentDbContext ctx;
        public StudentServices (RegistryStudentDbContext ctx)
        {
            this.ctx = ctx;
        }
        //Am creeat o metoda de a adauga studenti si in student service si am modficat-o pentru a nu outea adauga duplicate 
        public Student AddStudent(string name, string lastName, int age)
        {
            var student = ctx.Students.FirstOrDefault(s => s.Name == name);
            if (student != null)
            {
                return student;
            }
                
             student = new Student { Name = name, LastName = lastName, Age = age };
            ctx.Students.Add(student);
            return student;
            
        }
        //Am creeat o metoda prin care obtinem toti studentii
        [HttpGet]
        public List<Student> GetAll() =>
            ctx.Students.ToList();
        //Am creeat o metoda de a obtine studentilor dupa Id
        public Student GetStudentById(Guid Id)=>
            ctx.Students.FirstOrDefault(s => s.Id == Id);
        //Am creeat o functie de stergere a unui student
        public Student DeleteStudentByName(string Name) =>
            ctx.Students.FirstOrDefault(s => s.Name == Name);
        //Am creeat o metoda care modifica datele studentului
        public Student ChangeStudent(string LastName) =>
            ctx.Students.FirstOrDefault(s => s.LastName == LastName);
        //Am creeat o metoda care sterge un student cu tot cu adresa 
        public Student DeleteStudent(string Name) =>
            ctx.Students.FirstOrDefault(s => s.Name == Name);
            
    }
}
