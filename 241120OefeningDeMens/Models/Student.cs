using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241120OefeningDeMens.Models
{
    public class Student : Mens
    {
        public int Punten { get; set; }

        public Student(string voornaam, string achternaam, int punten) : base(achternaam,voornaam )
        {
            Punten = punten;
        }
        public override string ToString()
        {
            return $"achternaam: {achterNaam}  voornaam: {voorNaam} punten: {Punten}";
        }
    }
}
