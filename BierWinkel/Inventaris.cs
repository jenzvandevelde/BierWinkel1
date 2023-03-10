using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BierWinkel
{
    public class Inventaris
    {
        public Dictionary<string,Bier> Biertjes = new Dictionary<string,Bier>();

        public void VoegBierToe(double prijsPerstuk, string naam, Bierspecificatie bierspecificatie, Setgroote minimumhoeveelheid)
        {
            Bier bier = new Bier(prijsPerstuk, naam,bierspecificatie, minimumhoeveelheid);
            if (!Biertjes.ContainsKey(naam)) Biertjes.Add(bier.Naam,bier);
        }
        public Bier SelecteerBier(string naam)
        {
            if(Biertjes.ContainsKey(naam)) return Biertjes[naam];
            return null;
        }



        public List<Bier> ZoekBier(Bierspecificatie bier)
        {
            List<Bier> gevondenBiertjes = new List<Bier>();
            foreach(Bier b in Biertjes.values)
            {
                if (b.Bierspecifikatie.VoldoetAanSpecificatie(bier)) gevondenBiertjes.Add(b);
            }
            return gevondenBiertjes;
        }


        public bool VoldoetAanSpecificatie(Bierspecificatie spec)
        {
            bool ok = true;
                if (spec.Kleur != null && spec.Kleur != this.Kleur) ok=false;
                if (spec.Brouwerij != null && spec.Brouwerij.Length > 0 && 
                    spec.Brouwerij.ToLower() != this.Brouwerij.ToLower()) ok =false;
                if (spec.Volume != null && spec.Volume != this.Volume) ok = false;
                if (spec.AlcoholPercentage != null && spec.AlcoholPercentage
                != this.AlcoholPercentage) ok = false;
                if (spec.HerkomstLand != null && spec.HerkomstLand) != this.HerkomstLand) ok = false;
               
            
            return ok;
        }
    }
}
