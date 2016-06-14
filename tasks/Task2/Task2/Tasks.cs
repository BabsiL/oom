using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;


namespace Task2
{
	public static class Tasks
	{
		public static void Run()
		{

			var sonstiges = new Sonstiges[]
			{
				new Sonstiges("Alufix Alufloie", 12717, 2.99m, "Non food"),
				new Sonstiges("Toppits Abreiss Frischhaltefolie", 784828, 1.75m, "Non food"),
				new Sonstiges("Tempo Taschentücher classic", 401685, 2.59m, "Parfumerie"),
				new Sonstiges("Ajax Allzweckreiniger Frühlingsblumen", 852278, 2.99m, "Non Food"),
				new Sonstiges("Palmolive Flüssigseife Hygiene Plus", 707151, 2.89m, "Parfumerie"),
			};

			foreach (var x in sonstiges)
			{
				Task.Run(() =>
				{

					Task.Delay(1000).Wait();
					var prozent = ((x.Preis / 100) * 75);
					Console.WriteLine("-25% der Preise: " + prozent);


				}); 
			

			}

		}
	}
}