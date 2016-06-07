using System;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Linq;
using System.Threading;


namespace Task2
{
	public class Push_Lebensmittel
	{
		
		public static void Push()
		{
			//Subject erstellt
			var source = new Subject<Lebensmittel>();



			var thread = new Thread(() =>
			{
				//neue Lebensmittelobjekte pushen
				var i = 0;
				var lebensmittel = new Lebensmittel[]
				{
					
					new Lebensmittel ("San Lucar Bananen", 89103, 1.99m, "Obst und Gemüse"),
					new Lebensmittel ("Kotanyi Chili Mix scharf", 626784, 3.99m, "Lebensmittel"),
					new Lebensmittel ("Ströck Bauernbrot", 38323, 3.10m, "Feinkost"),
					new Lebensmittel ("Nöm Cremix Dessert Schoko-Banane", 436707, 0.59m, "Lebensmittel"),
					new Lebensmittel ("Conte De Cesare Balsamico", 420679, 2.99m, "Lebensmittel"),
					new Lebensmittel ("Pro Planet Karotten", 429089, 1.39m, "Obst und Gemüse"),

				};

				source
				//Nur Lebensmittel mit gültigem Namen (>0)ausgeben
					.Where(x => x.Name.Length > 0)
					.Subscribe(x => Console.WriteLine(x.Name))
				;
				while (i < lebensmittel.Length)
				{
					//Länge der Abstände während der Ausgabe (hier: 1/2 Sekunde)
					Thread.Sleep(500);
					//Nach der Reihe jeses Lebensmittel ausgeben von der obigen Liste
					source.OnNext(lebensmittel[i]);


					i++;
				}
			});
			thread.Start();



		}


	}
}

