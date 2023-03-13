using System;
using System.Text;
using System.Text.Json;

namespace Knowledge_Check_2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("How many different egg cartons do you want to add? ");
			var numberOfRecords = int.Parse(Console.ReadLine());

			var recordList = new List<Eggs>();
			for (int i = 0; i < numberOfRecords; i++)
			{
				// In this loop, populate the object's properties using Console.ReadLine()
				var myClass = new Eggs();

				Console.WriteLine("------------------------------------------");
				Console.WriteLine("Adding new egg carton!");

				Console.WriteLine("What color are the eggs in this carton?");
				myClass.ShellColor = Console.ReadLine();

				Console.WriteLine("How many eggs are in this carton?");
				myClass.NumberOfEggs = int.Parse(Console.ReadLine());

				Console.WriteLine("Are they jumbo size eggs? (y/n)");
				string jumboQuestion = Console.ReadLine();

				if (jumboQuestion == "y")
					myClass.IsJumboSize = true;
				else
				if (jumboQuestion == "n")
					myClass.IsJumboSize = false;
				else
				{
					Console.WriteLine("Invalid input, eggs will be regular size.");
					myClass.IsJumboSize = false;
				}


				Console.WriteLine("Enter the price for this carton of eggs.");
				myClass.Price = decimal.Parse(Console.ReadLine());

				Console.WriteLine("Enter the in stock quantity of the product.");
				myClass.QuantityInStock = int.Parse(Console.ReadLine());

				Console.WriteLine("Is this product on sale? (y/n)");
				string saleQuestion = Console.ReadLine();

				if (saleQuestion == "y")
					myClass.IsOnSale = true;
				else
				if (saleQuestion == "n")
					myClass.IsOnSale = false;
				else
				{
					Console.WriteLine("Invalid input, item will not be placed on sale.");
					myClass.IsOnSale = false;
				}

				Console.WriteLine(" ");

				recordList.Add(myClass);
			}

			// Print out the list of records using Console.WriteLine()
			for (int i = 0; i < recordList.Count; i++)
			{
				Console.WriteLine("Egg Carton(" + i + ") " + JsonSerializer.Serialize(recordList[i]));
			}
		}
	}
}