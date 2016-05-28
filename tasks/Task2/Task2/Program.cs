using System;
using System.Linq;
using Newtonsoft.Json;
using System.IO;
using System.Text;


namespace Task2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int auswahl;

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
				Console.WriteLine ("Neues Produkt");
				Console.WriteLine ("Name: " + x.Name + " \n" + "Artikelnummer: " + x.Artikelnummer + " \n" + "Preis: " + x.Preis + " \n" + "Warengruppenbereich: " + x.Warengruppenbereich + " \n" );
			}



			var i = 1;
				while(i!=0)
				{
				Console.WriteLine ("\nWas möchten Sie tun?");
				Console.WriteLine ("1 -> alle Preise auflisten");
				Console.WriteLine ("2 -> alle Produktnamen auflisten"); 
				Console.WriteLine ("3 -> alle Artikelnummern auflisten"); 
				Console.WriteLine ("4 -> Programm beenden");
				auswahl = Convert.ToInt32 (Console.ReadLine ());
					switch (auswahl) 
					{
						case 1:
							{
								var preise = produkte.Select (x => x.Preis).OrderBy (x => x);
								Console.WriteLine ();
								Console.WriteLine ("Preise:");
								foreach (var x in preise)
								Console.WriteLine (x);
								break;
							}
						case 2:
							{
								var namen = produkte.Select (x => x.Name).OrderBy (x => x);
								Console.WriteLine ();
								Console.WriteLine ("Produktnamen:");
								foreach (var x in namen)
								Console.WriteLine (x);
								break;
							}
						case 3:
						{
							var artikelnummern = produkte.Select (x => x.Artikelnummer).OrderBy (x => x);
							Console.WriteLine ();
							Console.WriteLine ("Artikelnummern:");
							foreach (var x in artikelnummern)
							Console.WriteLine (x);
							break;
						}
						case 4:
						{
							i=0;
							break;
						}
			
			
					}
				}
				
		}
	}
}
