using System;
using NUnit.Framework;
using System;
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




	}
}

