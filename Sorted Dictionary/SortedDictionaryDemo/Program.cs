using System;
using System.Collections.Generic;
using System.Linq;

namespace SortedDictionaryDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			SortedDictionary<int, int> sd = new SortedDictionary<int, int>();
			// Add some sample data
			sd.Add(6, 20);
			sd.Add(1, 11);
			sd.Add(11, 99);
			sd.Add(7,3);

			// get min key in sorted dictionary
			Console.WriteLine("The min key in sorted dictionary {0} should be 1", sd.Keys.First());

			// get max key in sorted dictionary
			Console.WriteLine("The max key in sorted dictionary {0} should be 11", sd.Keys.Last());

			// remove the key-value pair with min key from sorted dictionary and then check the min key again
			sd.Remove(sd.Keys.First());
			Console.WriteLine("The min key in sorted dictionary {0} should be 6", sd.Keys.First());

			// add a new key-value pair and check the max key again
			sd.Add(15, 6);
			Console.WriteLine("The max key in sorted dictionary {0} should be 15", sd.Keys.Last());

			// loop through the sorted dictionary
			foreach (var i in sd) {
				Console.WriteLine("Key is {0}, Value is {1}", i.Key, i.Value);
			}

			Console.WriteLine("\n\n\n");
			Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
			Console.WriteLine("\n\n\n");


			//############### Sorted Dictionary with Custom Comparer: sorted by key DESC #############
			SortedDictionary<int, int> desc_sd = new SortedDictionary<int, int>( new MyComparer() );

			// add some sample data
			desc_sd.Add(6,20);
			desc_sd.Add(1,11);
			desc_sd.Add(11,99);
			desc_sd.Add(7,3);

			// get min key in sorted dictionary
			Console.WriteLine("The min key in reversed sorted dictionary {0} should be 1", desc_sd.Keys.Last());

			// get max key in sorted dictionary
			Console.WriteLine("The max key in reversed sorted dictionary {0} should be 11", desc_sd.Keys.First());

			// remove the key-value pair with min key from sorted dictionary and then check the min key again
			desc_sd.Remove(desc_sd.Keys.Last());
			Console.WriteLine("The min key in reversed sorted dictionary {0} should be 6", desc_sd.Keys.Last());

			// add a new key-value pair and check the max key again
			desc_sd.Add(15, 6);
			Console.WriteLine("The max key in reversed sorted dictionary {0} should be 15", desc_sd.Keys.First());

			// loop through the reversed sorted dictionary
			foreach (var i in desc_sd)
			{
				Console.WriteLine("Key is {0}, Value is {1}", i.Key, i.Value);
			}

			Console.ReadKey();
		}
	}
}
