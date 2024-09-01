using Microsoft.AspNetCore.Components.Forms;
using ProiectFinalWon7.Controllers;
using ProiectFinalWon7.Data;
using ProiectFinalWon7.Models;
using System.Globalization;
using System.Linq.Expressions;

namespace ProiectFinalWon7.Services
{
    public class AdresessServices
    {
        private readonly RegistryStudentDbContext ctx;
        public AdresessServices(RegistryStudentDbContext ctx)
        {
            this.ctx = ctx;
        }
        //Am scris o metoda de creeare a studentilor 
        public void AddAdress(string city, string street, int number)
        {
            var adress = ctx.Adresses.FirstOrDefault(a => a.City == city);
            if (adress != null)
            {
                return;
            }
            adress = new Adress { City = city, Street = street, Number = number };
            ctx.Adresses.Add(adress);
        }
        //Am creeat o metoda de obtinere a adreselor studentilor  dupa id
        public Adress GetAdressById(int id) =>
            ctx.Adresses.FirstOrDefault(a => a.Id == id);
        //AM creeat o metoda care modfica adresele studentilor 
        public Adress ChangeAdress(int Number) =>
            ctx.Adresses.FirstOrDefault(Number);
    }
}
