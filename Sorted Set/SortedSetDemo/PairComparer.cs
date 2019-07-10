using System;
using System.Collections.Generic;
using System.Text;

namespace SortedSetDemo
{
	public class PairComparer : IComparer<Pair>
	{
		public int Compare(Pair x, Pair y)
		{
			if (x.Key == y.Key)
			{
				return x.Value - y.Value;
			}
			else {
				return x.Key - y.Key;
			}

		}
	}
}
