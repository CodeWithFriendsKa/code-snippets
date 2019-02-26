using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Daten;

namespace Ue02a
{
    class Program
    {
        static void Main(string[] args)
        {
            Notiz n1 = new Notiz("Hello world!");
            Console.WriteLine(n1.text);
            n1.text = "Hallo Welt!";
            Console.WriteLine(n1.text);
            Notiz n2 = n1.Clone();
            n1.text = "Hello world!";
            Console.WriteLine(n2.text);

            Console.WriteLine();

            Blatt b1 = new Blatt(n1, new Notiz("Wie geht's?"));
            Console.WriteLine(b1.vorne.text + " -- " + b1.hinten.text);
            b1.vorne.text = "Hallo Welt!";
            Console.WriteLine(b1.vorne.text + " -- " + b1.hinten.text);
            n1.text = "Hallo Welt!";
            Console.WriteLine(b1.vorne.text + " -- " + b1.hinten.text);



            Console.ReadKey();
        }
    }
}
