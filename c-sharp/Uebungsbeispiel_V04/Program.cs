using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Daten;

namespace Uebungsbeispiel
{
    class Program
    {
        public interface IDruckbar
        {
            string Darstellung();
        }

        static public void Drucken(IDruckbar ding)
        {
            if (ding == null)
                throw new Exception();

            Console.WriteLine(ding.Darstellung());
        }

        static void Main(string[] args)
        {
            Mensch hugo = new Mensch();
            hugo.name = "Meier";
            hugo.vorname = "Hugo";
            Drucken(hugo);

            Hund waldi = new Hund();
            waldi.name = "Waldi";
            waldi.rasse = "Dackel";
            Drucken(waldi);

            Bild bild = new Bild();
            bild.maler = "Hugo Meier";
            bild.titel = "Mein Dackel Waldi";
            Drucken(bild);

            Console.ReadKey();
        }
    }
}
