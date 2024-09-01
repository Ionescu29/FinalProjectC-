namespace ProiectFinalWon7.Models
{
    //Aici am creeat modelele
    //Adaugam primary key si foreign key
    /*Student este caracterizat de urmatoarele
    • Nume
    • Prenume
    • Varsta
    • Adresa
    */

    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Adress Adress { get; set; }
        
    }
}
