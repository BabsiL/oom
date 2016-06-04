using System;
using System.Linq;
using Newtonsoft.Json;
using System.IO;
using System.Text;
using System.Reactive.Linq;
using System.Reactive.Subjects;


namespace Task2
{
	class MainClass
	{
		public static void Main(string[] args)
		{

			var produkte = new Produkte[]
			{
				new Lebensmittel ("Ja! Bio Zitronen 4Stück", 409346, 1.99m, "Obst und Gemüse"),
				new Lebensmittel ("San Lucar Bananen", 89103, 1.99m, "Obst und Gemüse"),
				new Lebensmittel ("Nöm Frische Vollmilch 3,5%", 411357, 1.09m, "Frischdienst"),
				new Getraenke ("Wegenstein Zweigelt Rosé", 614732, 2.49m, "Getränke"),
				new Getraenke ("Moet &Chandon imperial", 21311, 42.90m, "Getränke"),
				new Sonstiges ("Vivo Glas 2er Set- 180 ml", 403957,14.99m, "Non food"),
				new Sonstiges ("Ariel Flüssig Colour", 417462, 7.99m, "Parfumerie"),


			};



			var einstellungen = new JsonSerializerSettings() { Formatting = Formatting.Indented, TypeNameHandling = TypeNameHandling.Auto };
			string text = (JsonConvert.SerializeObject(produkte, einstellungen));
			Console.WriteLine(text);
			var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			var file = Path.Combine(desktop, "produkte.json");
			File.WriteAllText(file, text);
			var TextAusFile = File.ReadAllText(file);
			var ProdukteAusFile = JsonConvert.DeserializeObject<Produkte[]>(TextAusFile, einstellungen);

			foreach (var x in ProdukteAusFile)
			{
				Console.WriteLine("Neues Produkt");
				Console.WriteLine("Name: " + x.Name + " \n" + "Artikelnummer: " + x.Artikelnummer + " \n" + "Preis: " + x.Preis + " \n" + "Warengruppenbereich: " + x.Warengruppenbereich + " \n");
			}


			foreach (var x in ProdukteAusFile)
			{

				//ich will hier eigentlich nur für jeden Artikel eine neue Artikelnummer einlesen und wieder ausgeben
				//ungefähr so:
				//Console.WriteLine("neue Artikelnummer eingeben: \n");
				//int neuenummer = Int32.Parse(Console.ReadLine());
				//x.Artikelnummern_aktualisieren(neuenummer);
				//Das hier haben Sie nach der letzten Stunde ausprobiert:
				//var line = Console.ReadLine();
				//Console.WriteLine("DEBUG: " + line);
				//int neuenummer = Int32.Parse(line);
				//x.Artikelnummern_aktualisieren(line);
				//ich habe das jetzt alles auskommentiert weil das Programm so wie ich es jetzt habe eh läuft,
				//aber ich würde es generell trotzdem auch gerne so wie ich es mir vorgestellt habe schaffen...


				int neuenummer = x.Artikelnummer + 162384;
				x.Artikelnummern_aktualisieren(neuenummer);
				Console.WriteLine("Die neue Artikelnummer für {0} ist {1}", x.Name, x.Artikelnummer);
			}

			/*foreach (var x in produkte)
			{
				x.Preis = x.RabatteEinlösen(x.Preis);

			}*/


			}
			 
		}
	}


