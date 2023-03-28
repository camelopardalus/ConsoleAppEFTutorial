using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEFTutorial.Model {
    public class Boek {
        public Boek(string titel, string beschrijving) {
            Titel = titel;
            Beschrijving = beschrijving;
        }

        public Boek(string titel, string beschrijving, Uitgeverij uitgeverij, List<Auteur> auteurs) : this(titel, beschrijving) {
            Uitgeverij = uitgeverij;
            Auteurs = auteurs;
        }

        public int Id { get; set; }
        public string Titel { get; set; }
        public string Beschrijving { get; set; }
        public Uitgeverij Uitgeverij { get; set; }
        public List<Auteur> Auteurs { get; set; } = new List<Auteur>();
    }
}
