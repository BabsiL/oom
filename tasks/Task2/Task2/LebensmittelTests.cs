using NUnit.Framework;
using System;
using Task2;

namespace LebensmittelTests
{
	[TestFixture]
	public class ProdukteTests
	{
		[Test]
		public void kannProduktErstellen()
		{
			var x = new Lebensmittel("Ja! Bio Zitronen 4Stück", 409346, 1.99m, "Obst und Gemüse");

			Assert.IsTrue(x.Name == "Ja! Bio Zitronen 4Stück");
			Assert.IsTrue(x.Artikelnummer == 409346);
			Assert.IsTrue(x.Preis == 1.99m);
			Assert.IsTrue(x.Warengruppenbereich == "Obst und Gemüse");
		}

		[Test]
		public void KannProduktNichtMitLeeremTitelErstellen1()
		{
			Assert.Catch(() =>
			{
				var x = new Lebensmittel(null, 409346, 1.99m, "Obst und Gemüse");
			});
		}

		[Test]
		public void KannProduktNichtMitLeeremTitelErstellen2()
		{
			Assert.Catch(() =>
			{
				var x = new Lebensmittel("", 409346, 1.99m, "Obst und Gemüse");
			});
		}
	

		[Test]
		public void KannProduktNichtMitNegativemOderLeeremPreisErstellen()
		{
			Assert.Catch(() =>
			{
				var x = new Lebensmittel("Ja!Bio Zitronen 4Stück", 409346, -1, "Obst und Gemüse");
				var y = new Lebensmittel("Ja!Bio Zitronen 4Stück", 409346, 0, "Obst und Gemüse");
			});
		}



		[Test]
		public void KannProduktNichtMitNegativerOderLeererArtikelnummerErstellen()
		{
			Assert.Catch(() =>
			{
				var x = new Lebensmittel("Ja!Bio Zitronen 4Stück", -1, 1.99m, "Obst und Gemüse");
				var y = new Lebensmittel("Ja!Bio Zitronen 4Stück", 0, 1.99m, "Obst und Gemüse");
			});
		}

		
	}
}

