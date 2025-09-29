using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrijvenDomein
{
    public class Bedrijf
    {
        public Bedrijf(string naam, string sector, string industrie, string extraInfo, string hoofdkwartier, int jaarOprichting, List<Personeel> personeel)
        {
            Naam = naam;
        }

        public string Naam { get; set; }
        public string Sector { get; set; }
        public string Industrie { get; set; }

        public int jaarOprichting { get; set; }
        
        public List<Personeel> Personeel { get; set; }
    }
}
