using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BierWinkel
{
    public class Bier
    {
        public Bier(double prijsPerstuk, string naam, Bierspecificatie bierspecifikatie,Setgroote minimumHoeveelheid)
        {
            if (prijsPerstuk <= 0) throw new Exception("Prijs moet groter zijn dan 0");
            PrijsPerStuk = prijsPerstuk;
            if (string.IsNullOrWhiteSpace(naam)) throw new Exception("naam mag niet leeg zijn");
            Naam = naam;
            this.Bierspecifikatie = bierspecifikatie;
            MinimumHoeveelheid = minimumHoeveelheid;
        }
        public Bierspecificatie Bierspecifikatie { get; private set; }
        public double PrijsPerStuk { get; set; }
        public string Naam { get; set; }
        public Setgroote MinimumHoeveelheid { get; set; }

        public override string ToString()
        {
           
        }
    }
}
