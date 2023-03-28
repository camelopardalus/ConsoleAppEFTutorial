using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEFTutorial.Model {
    public class BoekContext : DbContext {
        public DbSet<Boek> Boeken { get; set; }
        public DbSet<Auteur> Auteurs { get; set; }
        public DbSet<Uitgeverij> Uitgeverijen { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=BoekDB2023;Integrated Security=True;TrustServerCertificate=True");
            //Om te checken wat er achter de schermen gebeurt: 
            //.LogTo(Console.WriteLine, LogLevel.Information);
        }
    }
}
