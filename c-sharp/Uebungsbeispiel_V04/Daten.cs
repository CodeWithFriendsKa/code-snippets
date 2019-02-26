using System;
using Uebungsbeispiel;

namespace Daten
{
    abstract class Lebewesen : Program.IDruckbar
    {
        public string name;

        public abstract string Darstellung();
    }

    class Mensch : Lebewesen
    {
        public string vorname;

        public override string Darstellung()
        {
            return vorname + " " + name;
        }
    }

    class Hund : Lebewesen
    {
        public string rasse;

        public override string Darstellung()
        {
            return name + " (" + rasse + ")";
        }
    }

    class Bild : Program.IDruckbar
    {
        public string maler;
        public string titel;

        public string Darstellung()
        {
            return "\"" + titel + "\" von " + maler;
        }
    }
}