using System;
using Daten;

namespace Uebungsbeispiel2
{
	class MainClass
	{
		public static void Drucken(Termin t)
		{
			Console.Write(t.zeitpunkt.ToString() + ": " + t.anlass);
			if (t is Verabredung)
			{
				Verabredung v = t as Verabredung;
				Console.WriteLine(" mit " + v.person);
			}
			else if (t is Telefonat)
			{
				Console.WriteLine(" (" + (t as Telefonat).telefonnummer + ")");
			}
			else
				Console.WriteLine();
		}
		
		public static void Main (string[] args)
		{
			Termin t = new Termin();
			t.anlass = "Zahnarzt";
			t.zeitpunkt = new DateTime(2012, 11, 11, 10, 00, 00);
			
			Verabredung v = new Verabredung();
			v.anlass = "Abendessen";
			v.zeitpunkt = new DateTime(2012, 11, 9, 20, 00, 00);
			v.person = "Tim";
			
			Telefonat te = new Telefonat();
			te.anlass = "Terminabsage Zahnarzt";
			te.zeitpunkt = new DateTime(2012, 11, 9);
			te.telefonnummer = "01234/56789";
				
			Drucken(t);
			Drucken(v);
			Drucken(te);
			
			Console.ReadKey();
		}
	}
}
