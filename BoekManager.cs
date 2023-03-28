using ConsoleAppEFTutorial.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEFTutorial {
    public class BoekManager {
        // de boekmanager heeft een boekcontext nodig
        private BoekContext ctx = new BoekContext();

        public void VoegBoekToe(Boek boek) {
            ctx.Boeken.Add(boek);
            ctx.SaveChanges();
        }
    }
}
