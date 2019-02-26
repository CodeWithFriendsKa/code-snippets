using System;
using System.Collections.Generic;

namespace Daten
{
    class Buch
    {
        private string _titel;
        private string _autor;

        public string titel { get { return _titel; } }
        public string autor { get { return _autor; } }

        public Buch(string titel, string autor)
        {
            if (String.IsNullOrEmpty(titel))
                throw new Exception("Titel fehlt!");
            if (String.IsNullOrEmpty(autor))
                throw new Exception("Autor fehlt!");

            _titel = titel;
            _autor = autor;
        }
    }

    class Buchliste
    {
        private List<Buch> _bücher;

        // public List<Buch> bücher { get { return _bücher; } }
        public int anzahlBücher { get { return _bücher.Count; } }
        public string alleBücher
        {
            get
            {
                string s = "";
                foreach (Buch b in _bücher)
                    s += b.autor + ": " + b.titel + "\n";
                return s;
            }
        }

        public Buchliste()
        {
            _bücher = new List<Buch>();
        }

        public void Zufügen(Buch buch)
        {
            if (buch == null)
                throw new Exception("Das Buch fehlt!");

            _bücher.Add(buch);
        }

    }
}
