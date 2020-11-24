using _241120OefeningDeMens.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241120OefeningDeMens
{
    class Program
    {
// Test zeker ook de BerekenUurLoon() methode
//uit de klasse Werknemer

        static void Main(string[] args)
        {

            Mens mens = new Mens("spillebeen","Ruben");

            Werknemer werknemer = new Werknemer("Louis","Fille", 8 , 2000);

            Student student = new Student("G","Mauro", 100);

            Console.WriteLine(mens.ToString());
            Console.WriteLine(werknemer.ToString());
            Console.WriteLine(student.ToString());
        }
    }
}
