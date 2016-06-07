using System;
using NUnit.Framework;
using Task2;

namespace SonstigesTests
{
	[TestFixture]
	public class SonstigesTests
	{
		[Test]
		public void kannProduktErstellen()
		{
			var x = new Sonstiges("Ariel Flüssig Colour", 417462, 7.99m, "Parfumerie");

			Assert.IsTrue(x.Name == "Ariel Flüssig Colour");
			Assert.IsTrue(x.Artikelnummer == 417462);
			Assert.IsTrue(x.Preis == 7.99m);
			Assert.IsTrue(x.Warengruppenbereich == "Parfumerie");
		}

		[Test]
		public void KannProduktNichtMitLeeremTitelErstellen1()
		{
			Assert.Catch(() =>
			{
				var x = new Sonstiges(null, 417462, 7.99m, "Parfumerie");
			});
		}

		[Test]
		public void KannProduktNichtMitLeeremTitelErstellen2()
		{
			Assert.Catch(() =>
			{
				var x = new Sonstiges("", 417462, 7.99m, "Parfumerie");
			});
		}



		[Test]
		public void KannProduktNichtMitNegativemPreisErstellen()
		{
			Assert.Catch(() =>
			{
				var x = new Sonstiges("Ariel Flüssig Colour", 417462, -1, "Parfumerie");
			});
		}


		[Test]
		public void KannProduktNichtMitNegativemOderLeeremPreisErstellen()
		{
			Assert.Catch(() =>
			{
				var x = new Lebensmittel("Ariel Flüssig Colour", 417462, -1, "Parfumerie");
				var y = new Lebensmittel("Ariel Flüssig Colour", 417462, 0, "Parfumerie");
			});
		}



		[Test]
		public void KannProduktNichtMitNegativerOderLeererArtikelnummerErstellen()
		{
			Assert.Catch(() =>
			{
				var x = new Lebensmittel("Ariel Flüssig Colour", -1, 7.99m, "Parfumerie");
				var y = new Lebensmittel("Ariel Flüssig Colour", 0, 7.99m, "Parfumerie");
			});
		}


	}
}

