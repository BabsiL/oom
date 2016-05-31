using NUnit.Framework;
using System;
using Task2;

namespace GetraenkelTest
{
	[TestFixture]
	public class GetraenkeTest
	{
		[Test]
		public void kannProduktErstellen()
		{
			var x = new Getraenke("Moet &Chandon imperial", 21311, 42.90m, "Getränke");

			Assert.IsTrue(x.Name == "Moet &Chandon imperial");
			Assert.IsTrue(x.Artikelnummer == 21311);
			Assert.IsTrue(x.Preis == 42.90m);
			Assert.IsTrue(x.Warengruppenbereich == "Getränke");
		}

		[Test]
		public void KannProduktNichtMitLeeremTitelErstellen1()
		{
			Assert.Catch(() =>
			{
				var x = new Getraenke(null, 21311, 42.90m, "Getränke");
			});
		}

		[Test]
		public void KannProduktNichtMitLeeremTitelErstellen2()
		{
			Assert.Catch(() =>
			{
				var x = new Getraenke("", 21311, 42.90m, "Getränke");
			});
		}



		[Test]
		public void KannProduktNichtMitNegativemPreisErstellen()
		{
			Assert.Catch(() =>
			{
				var x = new Getraenke("Moet &Chandon imperial", 21311, -1, "Getränke");
			});
		}




	}
}

