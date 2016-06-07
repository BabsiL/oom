using System;

namespace Task2
{
	public class Sonstiges : Produkte
	{

		//private field
		private int m_artikelnummer;

		//constructor
		public Sonstiges (string name, int artikelnummer, decimal preis, string warengruppenbereich)
		{

			if(preis<0) throw new ArgumentException("Der Preis darf keinen negativen Wert haben.", nameof(preis));
			if(String.IsNullOrWhiteSpace(name)) throw new ArgumentException("Der Name ist ungültig.", nameof(name));

			this.Name = name;
			this.Preis = preis;
			this.Warengruppenbereich = warengruppenbereich;
			Artikelnummern_aktualisieren(artikelnummer);



		}

		//public property
		public string Name 
		{  
			get;
			set;

		}

		//public property
		public string Warengruppenbereich 
		{
			get;
		}

		//public property
		public decimal Preis 
		{  
			get;
			set;
		}

		//public property
		public int Artikelnummer
		{ 
			get 
			{ 
				return m_artikelnummer; 
			} 
		}

		//public method
		public void Artikelnummern_aktualisieren(int neue_artikelnummer)
		{
			if(neue_artikelnummer<0) throw new ArgumentException("Die Artikelnummer ist ungültig.", nameof(neue_artikelnummer));
			m_artikelnummer = neue_artikelnummer;
		}
	

		/*public decimal RabatteEinlösen(decimal preis)
		{
			Console.WriteLine("Wieviel Prozent Rabatt?\n");
			var prozent = Convert.ToDecimal(Console.ReadLine());
			if (prozent > 0)
			{
				return preis = (prozent / 100) * preis;
			}
			else return 0;

		}*/

	}
}
