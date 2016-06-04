using System;

namespace Task2
{
	public interface Produkte
	{
		string Name{ get; set;}
		decimal Preis { get; set;}
		int Artikelnummer{get;}
		string Warengruppenbereich {get;}
		void Artikelnummern_aktualisieren(int neue_artikelnummer);
		//decimal RabatteEinlösen(decimal preis);

	}
}

