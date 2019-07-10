using System;
using System.Collections.Generic;

namespace SortedSetDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			// create a new sorted set with initialization
			SortedSet<int> ss = new SortedSet<int>(new int[] { 6,2,5,7,10,1,17});

			// get the max
			Console.WriteLine("The max number in sorted set should be {0} (17)", ss.Max);

			// get the min
			Console.WriteLine("The min number in sorted set should be {0} (1)", ss.Min);

			// remove current max, and then get the max again
			ss.Remove(ss.Max);
			Console.WriteLine("The max number in sorted set should be {0} (10)", ss.Max);

			// remove current min, and then get the min again
			ss.Remove(ss.Min);
			Console.WriteLine("The min number in sorted set should be {0} (2)", ss.Min);

			// add a new num and then get the max again
			ss.Add(99);
			Console.WriteLine("The max number in sorted set should be {0} (99)", ss.Max);

			// add a new num and then get the min again
			ss.Add(-1);
			Console.WriteLine("The min number in sorted set should be {0} (-1)", ss.Min);

			Console.WriteLine("\n\n\n");
			Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~Sorted Set with Custom Comparer~~~~~~~~~~~~~~~~~~~~~~");
			Console.WriteLine("\n\n\n");

			// pairs will be sorted by key then value
			SortedSet<Pair> pairs = new SortedSet<Pair>(new PairComparer());
			pairs.Add(new Pair(6,10));
			pairs.Add(new Pair(3, 7));
			pairs.Add(new Pair(6, 5));
			pairs.Add(new Pair(11, 10));
			pairs.Add(new Pair(2, 10));
			pairs.Add(new Pair(6, 3));

			// get the max 
			Console.WriteLine("The max pair should be with key {0} and value {1} (11,10)", pairs.Max.Key, pairs.Max.Value);

			// get the min
			Console.WriteLine("The min pair should be with key {0} and value {1} (2,10)", pairs.Min.Key, pairs.Min.Value);

			// remove current min, and then get min again
			pairs.Remove(pairs.Min);
			Console.WriteLine("The min pair should be with key {0} and value {1} (3,7)", pairs.Min.Key, pairs.Min.Value);

			// remove current max, and then get max again
			pairs.Remove(pairs.Max);
			Console.WriteLine("The max pair should be with key {0} and value {1} (6,10)", pairs.Max.Key, pairs.Max.Value);

			// add new pair and remove min, and then get the min again
			pairs.Add(new Pair(7,7));
			pairs.Remove(pairs.Min);
			Console.WriteLine("The min pair should be with key {0} and value {1} (6,3)", pairs.Min.Key, pairs.Min.Value);

			// add new pair and then get the max again
			pairs.Add(new Pair(15,1));
			Console.WriteLine("The max pair should be with key {0} and value {1} (15,1)", pairs.Max.Key, pairs.Max.Value);


			Console.ReadKey();

		}
	}
}
