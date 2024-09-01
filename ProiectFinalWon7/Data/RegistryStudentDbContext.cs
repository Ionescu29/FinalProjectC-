using Microsoft.EntityFrameworkCore;
using ProiectFinalWon7.Models;

//In aceasta sectiune am populat Db context-ul 

namespace ProiectFinalWon7.Data
{
    public class RegistryStudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public RegistryStudentDbContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ionut\source\repos\ProiectFinalWon7\Project\StudentsRegistry.mdf;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
    
}
