using System;

namespace ConsoleAnimal
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] MyArray = new string[5] { "Zebra", "Ant", "Owl", "Lion", "Tigar" };


			//for loop
			Console.Write("MyArray: ");
			int i = 0;
			for (i = 0; i < MyArray.Length; i++)
			{
				Console.Write(" "+ MyArray[i]);
			}
			Console.WriteLine();

			//foreach loop
			Console.Write("MyArray: ");
			foreach (string ani in MyArray)
			{
				Console.Write(" " + ani);
			}
			Console.WriteLine();

			//do-while loop
			Console.Write("MyArray: ");
			int j = 0;
			do
			{
				Console.Write(" " + MyArray[j]);
				j++;
			}
			while (MyArray.Length > j);
			Console.WriteLine();

			//while loop
			Console.Write("MyArray: ");
			i = 0;
			while(MyArray.Length>i)
			{
				Console.Write(" " + MyArray[i]);
				i++;
			}
			Console.WriteLine();

			//sorted array
			Array.Sort(MyArray);
			Console.Write("Sorted MyArray is: ");
			foreach (string ani in MyArray)
			{
				Console.Write(" " + ani);
			}
			Console.WriteLine();

			string[] animals = new string[4] { "Zebra", "Kiwi", "Amazona Parrot", "Tiger" };
			string[] places = new string[4] { "Africa", "New Zealand", "Jamaica", "India" };

			Array.Sort(animals);
			Array.Sort(places);
			Console.Write("Soretd animal array:");
			foreach (string animal in animals)
			{
				Console.Write(" " + animal);
			}
			Console.WriteLine();
			Console.Write("Soretd places array:");
			foreach (string place in places)
			{
				Console.Write(" " + place);
			}
			Console.ReadLine();
		}
	}
}
