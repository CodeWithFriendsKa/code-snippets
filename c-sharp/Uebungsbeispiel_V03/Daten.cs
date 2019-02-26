using System;

namespace Daten
{
	class Termin
	{
		public string anlass;
		public DateTime zeitpunkt;
	}
	
	class Verabredung : Termin
	{
		public string person;
	}
	
	class Telefonat : Termin
	{
		public string telefonnummer;
	}
}
				