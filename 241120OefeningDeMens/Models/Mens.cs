using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241120OefeningDeMens.Models
{
    public class Mens
    {
        public string achterNaam { get; private set; }
        public string voorNaam { get; private set; }

        public Mens(string achternaam, string voornaam)
        {
            achterNaam = achternaam;
            voorNaam = voornaam;

        }

        public override string ToString()
        {
            return $"achternaam: {achterNaam}  voornaam: {voorNaam}";
        }
    }
}
