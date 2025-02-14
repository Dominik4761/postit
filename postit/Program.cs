using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postit
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Post v1 = new Post("sarga", " ");
			Post v2 = new Post("zold", " ");
			Post v3 = new Post("Kek", " ");

			v1.Tartalom = "zab, tej, liszt";
			v2.Tartalom = "+3670888459";
			v3.Tartalom = "16:00 Fogászat";


			Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Szín: {v1.Szin} Tartalom: {v1.Tartalom}");
			Console.BackgroundColor = ConsoleColor.Green;
			Console.WriteLine($"Szín: {v2.Szin} Tartalom: {v2.Tartalom}");
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.WriteLine($"Szín: {v3.Szin} Tartalom: {v3.Tartalom}");
			Console.BackgroundColor = ConsoleColor.Black;


			kruvA
	}
}
