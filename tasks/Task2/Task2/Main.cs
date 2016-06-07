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

			//Aray aus Objekten verschiedener Klassen
			var produkte = new Produkte[]
			{
				//Neue Objekte der Klassen erzeugen
				new Lebensmittel ("Ja! Bio Zitronen 4Stück",  409346, 1.99m, "Obst und Gemüse"),
				new Lebensmittel ("Billa Doppelschoko-Kuchen", 339574, 1.59m, "Feinkost"),
				new Lebensmittel ("Finis Feinstes Dinkelmehl", 869039, 2.09m, "Lebensmittel"),
				new Lebensmittel ("Bonduelle Goldmais",  413600, 1.49m, "Konserven"),
				new Lebensmittel ("Steirische Freilandeier mittel", 337984, 3.49m, "Frischdienst"),
				new Lebensmittel ("Ben & Jerrys Cookie Dough", 693076, 5.49m, "Tiefkühl"),
				new Lebensmittel ("Nöm Frische Vollmilch 3,5%", 411357, 1.09m, "Frischdienst"),
				new Getraenke ("Wegenstein Zweigelt Rosé", 614732, 2.49m, "Getränke"),
				new Getraenke ("Moet &Chandon imperial", 213110, 42.90m, "Getränke"),
				new Sonstiges ("Vivo Glas 2er Set- 180 ml", 403957,14.99m, "Non food"),
				new Sonstiges ("Ariel Flüssig Colour", 417462, 7.99m, "Parfumerie"),


			};
			//Ausgabe von allen Produkten
			foreach (var x in produkte)
			{
				Console.WriteLine("Neues Produkt");
				Console.WriteLine("Name: " + x.Name + " \n" + "Artikelnummer: " + x.Artikelnummer + " \n" + "Preis: " + x.Preis + " \n" + "Warengruppenbereich: " + x.Warengruppenbereich + " \n");
			}


			//serialisieren
			var einstellungen = new JsonSerializerSettings() { Formatting = Formatting.Indented, TypeNameHandling = TypeNameHandling.Auto };
			string text = (JsonConvert.SerializeObject(produkte, einstellungen));
			//serialisierte Produkte ausgeben
			Console.WriteLine(text);
			//File namens produkte.json wird nach dem hineinschreibem am Desktop gespeichert
			var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			var file = Path.Combine(desktop, "produkte.json");
			//alle serialisierten Produkte ins File am Desktop schreiben
			File.WriteAllText(file, text);
			//Produkte aus File lesen
			var TextAusFile = File.ReadAllText(file);
			//Deserialisieren
			var ProdukteAusFile = JsonConvert.DeserializeObject<Produkte[]>(TextAusFile, einstellungen);

			//ausgabe Für deserialisierte Produkte aus dem File
			foreach (var x in ProdukteAusFile)
			{
				Console.WriteLine("Neues Produkt");
				Console.WriteLine("Name: " + x.Name + " \n" + "Artikelnummer: " + x.Artikelnummer + " \n" + "Preis: " + x.Preis + " \n" + "Warengruppenbereich: " + x.Warengruppenbereich + " \n");
			}

			//Ausgabe für die Produkte aus dem File für die Funktion Artikelnummern_aktualisieren
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


				int neuenummer = x.Artikelnummer + 012384;
				x.Artikelnummern_aktualisieren(neuenummer);
				Console.WriteLine("Die neue Artikelnummer für {0} ist {1}", x.Name, x.Artikelnummer);
			}


			/*foreach (var x in produkte)
            {
                x.Preis = x.RabatteEinlösen(x.Preis);

            }*/

			Push_Lebensmittel.Push();
		}


	}
}
