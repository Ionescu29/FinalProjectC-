using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using ProiectFinalWon7.Data;
using ProiectFinalWon7.Models;
using ProiectFinalWon7.Services;

namespace ProiectFinalWon7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeedController : ControllerBase
    {
        private readonly StudentServices studentServices;
        public SeedController(StudentServices studentServices)
        {
            this.studentServices= studentServices;
        }

        //Am creeat o functie pentru a creea studenti 
        [HttpPost]
        public void Seed()
        {
            studentServices.AddStudent("Melinte", "Daniel", 23);
            studentServices.AddStudent("Macarie", "Andreea", 20);
            studentServices.AddStudent("Puscas", "Cosmin", 28);
            studentServices.AddStudent("Miron", "Ionut", 26);
        }
        
    }
}