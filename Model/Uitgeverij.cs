using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEFTutorial.Model {
    public class Uitgeverij {
        public Uitgeverij(string naam, string adres, string emailContact) {
            Naam = naam;
            Adres = adres;
            EmailContact = emailContact;
        }

        public int Id { get; set; }
        public string Naam { get; set; }
        public string Adres { get; set; }
        public string EmailContact { get; set; }
    }
}
