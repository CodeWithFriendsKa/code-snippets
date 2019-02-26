using System;

namespace Daten
{
    class Notiz
    {
        private string _text;

        public string text
        {
            get { return _text; }

            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception();

                _text = value;
            }
        }

        public Notiz(string text)
        {
            if (String.IsNullOrEmpty(text))
                throw new Exception();

            _text = text;
        }

        public Notiz Clone()
        {
            return new Notiz(this.text);
        }
    }

    class Blatt
    {
        private Notiz _vorne;
        private Notiz _hinten;

        public Notiz vorne { get { return _vorne.Clone(); } }
        public Notiz hinten { get { return _hinten.Clone(); } }

        public Blatt(Notiz vorne, Notiz hinten)
        {
            if (vorne == null || hinten == null)
                throw new Exception();

            _vorne = vorne.Clone();
            _hinten = hinten.Clone();
        }

#if false
        // flache Kopie
        public Blatt(Blatt original)
        {
            if (original == null)
                throw new Exception();

            _vorne = original._vorne;
            _hinten = original._hinten;
        }
#endif
        // tiefe Kopie
        public Blatt(Blatt original)
        {
            if (original == null)
                throw new Exception();

            //_vorne = original._vorne.Clone();
            //_hinten = original._hinten.Clone();
            _vorne = original.vorne;
            _hinten = original.hinten;
        }

    }
}