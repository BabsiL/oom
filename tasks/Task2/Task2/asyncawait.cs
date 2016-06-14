using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;
using static System.Console;
using System.Threading;



namespace Task2
{
	public static class asyncawait
	{

		public static async Task Asyncawait()
		{
			
			Task<int> task = Waitasyncawait();
			var getraenke = new Getraenke[]
				{

					new Getraenke ("Wieselburger Gold", 504149, 0.96m, "Getränke"),
					new Getraenke ("Vöslauer Prickelnd", 405686, 0.49m, "Getränke"),
					new Getraenke ("Darbo Sirup Zitronenmelisse", 433582, 4.99m, "Getränke"),
					new Getraenke ("Jameson Irish Whiskey", 752887, 29.90m, "Getränke"),
					new Getraenke ("Happy Day Mangosaft", 862454, 1.49m, "Getränke"),

				};
				foreach(var x in getraenke)
			{
				Console.WriteLine("Getränkpreis: für " + x.Name + ": " + x.Preis);
				await Task.Delay(1000);
			}



		}

		public static async Task<int> Waitasyncawait()
		{
			int i;

			for (i = 1; i < 6; i++)
			{
				await Task.Delay(1000); //1/2 Sekunde verzögerung
				Console.WriteLine("...");

			}
			return i;




		}


	}
}