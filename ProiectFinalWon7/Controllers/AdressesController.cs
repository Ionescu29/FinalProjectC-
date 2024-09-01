using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProiectFinalWon7.DTO;
using ProiectFinalWon7.Models;
using ProiectFinalWon7.Services;

namespace ProiectFinalWon7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdressesController : ControllerBase
    {
        private readonly AdresessServices adresessServices;
        private readonly StudentServices studentServices;
        public AdressesController(StudentServices studentServices, AdresessServices adresessServices)
        {
            this.studentServices = studentServices;
            this.adresessServices = adresessServices;
        }
        [HttpPost]
        public Adress AddAdress([FromBody] AdressToCreateDTO adressToCreate)=> 
            adresessServices.AddAdress(adressToCreate.City, adressToCreate.Street, adressToCreate.Number);

        [HttpGet]
        public Adress GetAdressById(int id) =>
            adresessServices.GetAdressById(id);
        [HttpPost]
        public Adress ChangeAdress(string City) =>
            adressesServices.ChangeAdress(City);
    }
    
}
