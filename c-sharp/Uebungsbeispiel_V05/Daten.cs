using System;

namespace Daten
{
	abstract class Gebäude
	{
		private int _grundfläche;
		
		public int grundfläche
		{
			get
			{
				return _grundfläche;
			}
			
			protected set
			{
				if (value < 1)
					throw new Exception();
				_grundfläche = value;
			}
		}
		
		public Gebäude(int grundfläche)
		{
			this.grundfläche = grundfläche;
		}
		
		public override bool Equals (object obj)
		{
			Gebäude g = obj as Gebäude;
			return g != null && _grundfläche.Equals(g._grundfläche);
		}
		
		public override int GetHashCode ()
		{
			return _grundfläche.GetHashCode();
		}
		
		public override string ToString ()
		{
			return string.Format ("[Gebäude: grundfläche={0}]\n", grundfläche);
		}
	}
	
	class Haus : Gebäude
	{
		private int _anzahlStockwerke;
		
		public int anzahlStockwerke { get { return _anzahlStockwerke; } }
		
		public Haus(int grundfläche, int anzahlStockwerke) : base(grundfläche)
		{
			if (anzahlStockwerke < 1)
				throw new Exception();
			
			_anzahlStockwerke = anzahlStockwerke;
		}
			
		public void Anbauen(int zusätzlicheQm)
		{
			if (zusätzlicheQm < 1)
				throw new Exception();
			
			grundfläche += zusätzlicheQm;
		}
		
		public override bool Equals (object obj)
		{
			Haus h = obj as Haus;
			return h != null && base.Equals (obj) && _anzahlStockwerke.Equals(h._anzahlStockwerke);
		}
		
		public override int GetHashCode ()
		{
			return base.GetHashCode () ^ _anzahlStockwerke.GetHashCode();
		}
		
		public override string ToString ()
		{
			return base.ToString() + string.Format ("[Haus: anzahlStockwerke={0}]\n", anzahlStockwerke);
		}

        public Haus Kopie()
        {
            return (Haus) MemberwiseClone();
        }
	}
	
	class Bungalow : Haus
	{
		public Bungalow(int grundfläche) : base(grundfläche,1)
		{}
		
		public Bungalow() : this(70)
		{}
		
		public override bool Equals (object obj)
		{
			Bungalow bungalow = obj as Bungalow;
			return bungalow != null && base.Equals (obj);
		}
	}
}
