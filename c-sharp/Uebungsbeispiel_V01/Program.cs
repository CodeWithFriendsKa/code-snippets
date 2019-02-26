using System;
using Daten;

namespace Uebungsbeispiel2
{
    class Program
    {
        static void Main(string[] args)
        {
            Buchliste bliste = new Buchliste();

            Buch buch1 = new Buch("Max und Moritz", "Busch, Wilhelm");
            bliste.Zufügen(buch1);
            bliste.Zufügen(new Buch("Steppenwolf", "Hesse, Hermann"));

            Console.WriteLine(bliste.anzahlBücher);
            Console.WriteLine(bliste.alleBücher);

            Console.ReadKey();
        }
    }
}
