using System;

namespace Daten
{

    class Hund
    {
        private string _name;

        public string name
        {
            get
            {
                return _name;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception();

                _name = value;
            }
        }

        public Hund(string name)
        {
            if (String.IsNullOrEmpty(name))
                throw new Exception();

            _name = name;
        }

        public Hund(Hund hund)
        {
            if (hund == null)
                throw new Exception();

            _name = hund._name;
        }

        public Hund NeuerHund()
        {
            return new Hund(this._name);
            //return new Hund(this);
        }
    }

    class Hütte
    {
        private Hund _hund;

        public Hund hund { get { return _hund; } }

        public Hütte(Hund hund)
        {
            if (hund == null)
                throw new Exception();

            _hund = hund;
        }

        public Hütte Referenzkopie()
        {
            return this;
        }

        public Hütte FlacheKopie()
        {
            return new Hütte(_hund);
        }

        public Hütte TiefeKopie()
        {
            return new Hütte(new Hund(_hund));
        }
    }
}