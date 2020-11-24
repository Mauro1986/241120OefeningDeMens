using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241120OefeningDeMens.Models
{
    public class Werknemer : Mens
    {
        public int UrenPerdag { get; set; }
        public int WeekSalaris { get; set; }
        public double UurLoon { get; set; }

        public Werknemer(string voornaam, string achternaam, int urenperdag, int weeksalaris) :base(voornaam,achternaam)
        {
            WeekSalaris = weeksalaris;
            UrenPerdag = urenperdag;
            BerekenUurloon(urenperdag, weeksalaris);
        }
        public override string ToString()
        {
            return $"achternaam: {achterNaam}  voornaam: {voorNaam} weeksalaris: {WeekSalaris}  urenperdag:{UrenPerdag} uurloon: {UurLoon}";
        }

        public void BerekenUurloon(int urenPerdag, int weekSalaris)
        {
            UurLoon =(double) (weekSalaris /( 5 * urenPerdag));
        }
    }
}
