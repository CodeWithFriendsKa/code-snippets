using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Daten;

namespace Uebungsbeispiel3b
{
    class Program
    {


        static void Main(string[] args)
        {
            Hund bello = new Hund("Bello");

            Hütte h1 = new Hütte(bello);

            // Referenzkopie -- alte Hütte
            Hütte h2 = h1.Referenzkopie();

            // flache Kopie -- neue Hütte, alter Hund
            Hütte h3 = h1.FlacheKopie();

            // tiefe Kopie -- neue Hütte, neuer Hund
            Hütte h4 = h1.TiefeKopie();

            h4.hund.name = "Waldi";
            Console.WriteLine(h1.hund.name);

            h3.hund.name = "Waldi";
            Console.WriteLine(h1.hund.name);

            Console.ReadKey();
        }
    }
}
