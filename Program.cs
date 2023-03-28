using ConsoleAppEFTutorial.Model;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace ConsoleAppEFTutorial {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!");
            Uitgeverij uitgeverij = new Uitgeverij("Lannoo", "Kasteelstraat 97, 8700 Tielt", "info@lannoo.be");
            Auteur a1 = new Auteur("Fieke van der Gucht", "fieke.vandergucht@ugent.be");
            Boek b1 = new Boek("Het groot Vlaams vloekboek", "bla bla bla");
            b1.Uitgeverij = uitgeverij;
            b1.Auteurs.Add(a1);

            BoekManager bm = new BoekManager();
            bm.VoegBoekToe(b1);
        }
    }
}