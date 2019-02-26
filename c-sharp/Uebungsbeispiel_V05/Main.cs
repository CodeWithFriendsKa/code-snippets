using System;
using Daten;

namespace Uebungsbeispiel1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Haus h1 = new Haus(60, 3);
			Haus h2 = new Haus(70, 1);
			
			Console.WriteLine(h1.ToString() + " " + h1.GetHashCode());
			Console.WriteLine(h2.ToString() + " " + h2.GetHashCode());
			Console.WriteLine(h1.Equals(h2));
			h1.Anbauen(10);
			Console.WriteLine(h1.ToString() + " " + h1.GetHashCode());
			Console.WriteLine(h1.Equals(h2));
            Haus h3 = h1.Kopie();
            Console.WriteLine(h1.Equals(h3));
            h3.Anbauen(10);
            Console.WriteLine(h1.Equals(h3));
			
			Console.WriteLine();
			
			Bungalow b1 = new Bungalow(60);
			Bungalow b2 = new Bungalow();
			
			Console.WriteLine(b1.ToString() + " " + b1.GetHashCode());
			Console.WriteLine(b2.ToString() + " " + b2.GetHashCode());
			Console.WriteLine(b1.Equals(b2));
			b1.Anbauen(10);
			Console.WriteLine(b1.ToString() + " " + b1.GetHashCode());
			Console.WriteLine(b1.Equals(b2));
			Console.WriteLine(Bungalow.ReferenceEquals(b1, b2));
			Console.WriteLine(b1 == b2);
			
			Console.WriteLine();
			
			Console.WriteLine(h2.Equals(b2));
			Console.WriteLine(b2.Equals(h2));

            Console.ReadKey();
		}
	}
}
