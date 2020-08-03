using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ConsoleAnimal
{
	class ConString
	{
		void Display()
		{
			Console.WriteLine("1. Concatenate Strings. ");
			Console.WriteLine("2. Length of two strings. ");
			Console.WriteLine("3. Substring ");
			Console.WriteLine("4. Replace. ");
			Console.WriteLine("5. Uppercase.");
			Console.WriteLine("6. Lowercase.");
			Console.WriteLine("7. Trim. ");
			Console.WriteLine("8. Split. ");
			Console.WriteLine("Enter 9 to exit and 0 to main menu");
		}
		static void Main()
		{
			//string first="Good Morning India"
			Console.WriteLine("Enter First String: ");
			string first = Console.ReadLine();
			Console.WriteLine("Enter Second String: ");
			string second = Console.ReadLine();

			string s = String.Concat(first, second);

			ConString cstr = new ConString();

		checkpoint: Console.WriteLine();
			Console.WriteLine("===============================================================");
			cstr.Display();
			int choice =Convert.ToInt32( Console.ReadLine());
			switch (choice)
			{
				case 1:
					string str = first + second;
					Console.WriteLine(first+second);
					goto checkpoint;
				case 2:
					Console.WriteLine("Length of first string is: {0} and second string is : {1}",first.Length,second.Length);
					goto checkpoint;
				case 3:
					Console.WriteLine("Enter substring index: ");
					int index = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine(s.Substring(index));
					goto checkpoint;

				case 4:
					Console.WriteLine("what should be replaced: ");
					char from = Convert.ToChar(Console.ReadLine());
					Console.WriteLine("To Which: ");
					char to = Convert.ToChar(Console.ReadLine());
					Console.WriteLine(s.Replace(from, to));
					goto checkpoint;
				case 5:
					Console.WriteLine(first.ToUpper());
					Console.WriteLine(second.ToUpper());
					goto checkpoint;
				case 6:
					Console.WriteLine(first.ToLower());
					Console.WriteLine(second.ToLower());
					goto checkpoint;
				case 7:
					Console.WriteLine(first.Trim());
					Console.WriteLine(second.Trim());
					goto checkpoint;
				case 8:
					char[] separator = {' ',',' };
					int count = 9;
					string[] splitedString = s.Split(separator, count);
					foreach (string word in splitedString)
					{
						Console.WriteLine(word);
					}
					goto checkpoint;
				case 9:
					break;
				default:
					break;
			}
			Console.Read();
		}
	}
}
