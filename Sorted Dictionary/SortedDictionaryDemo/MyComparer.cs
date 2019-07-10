using System.Collections.Generic;

namespace SortedDictionaryDemo
{
	public class MyComparer : IComparer<int>
	{
		public int Compare(int x, int y)
		{
			return y-x;
		}
	}
}
