using System;
using System.Collections.Generic;

namespace SortedListDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			SortedList<int, int> sl = new SortedList<int, int>();
			// Add some sample data
			sl.Add(6, 20);
			sl.Add(1, 11);
			sl.Add(11, 99);
			sl.Add(7, 3);

			// get min key in sorted list
			Console.WriteLine("The min key in sorted list {0} should be 1", sl.Keys[0]);

			// get max key in sorted list
			Console.WriteLine("The max key in sorted list {0} should be 11", sl.Keys[sl.Count-1]);

			// remove the key-value pair with min key from sorted list and then check the min key again
			sl.RemoveAt(0);
			Console.WriteLine("The min key in sorted list {0} should be 6", sl.Keys[0]);

			// add a new key-value pair and check the max key again
			sl.Add(15, 6);
			Console.WriteLine("The max key in sorted list {0} should be 15", sl.Keys[sl.Count-1]);

			// loop through the sorted list
			Console.WriteLine("\n");
			Console.WriteLine("Traverse the sorted List...");
			Console.WriteLine("\n");
			foreach (var i in sl)
			{
				Console.WriteLine("Key is {0}, Value is {1}", i.Key, i.Value);
			}

			Console.WriteLine("\n\n\n");
			Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
			Console.WriteLine("\n\n\n");

			//############### Sorted list with Custom Comparer: sorted by key DESC #############
			SortedList<int, int> desc_sl = new SortedList<int, int>(new SortedListComparer());

			// add some sample data
			desc_sl.Add(6, 20);
			desc_sl.Add(1, 11);
			desc_sl.Add(11, 99);
			desc_sl.Add(7, 3);

			// get min key in sorted list
			Console.WriteLine("The min key in reversed sorted list {0} should be 1", desc_sl.Keys[desc_sl.Count-1]);

			// get max key in sorted list
			Console.WriteLine("The max key in reversed sorted list {0} should be 11", desc_sl.Keys[0]);

			// remove the key-value pair with min key from sorted list and then check the min key again
			desc_sl.RemoveAt(desc_sl.Count-1);
			Console.WriteLine("The min key in reversed sorted list {0} should be 6", desc_sl.Keys[desc_sl.Count-1]);

			// add a new key-value pair and check the max key again
			desc_sl.Add(15, 6);
			Console.WriteLine("The max key in reversed sorted list {0} should be 15", desc_sl.Keys[0]);

			// loop through the reversed sorted list
			Console.WriteLine("\n");
			Console.WriteLine("Traverse the sorted List...");
			Console.WriteLine("\n");
			foreach (var i in desc_sl)
			{
				Console.WriteLine("Key is {0}, Value is {1}", i.Key, i.Value);
			}

			Console.ReadKey();
		}
	}
}
