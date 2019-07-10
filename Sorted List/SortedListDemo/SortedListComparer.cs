using System.Collections.Generic;

namespace SortedListDemo
{
	public class SortedListComparer : IComparer<int>
	{
		public int Compare(int x, int y)
		{
			return y - x;
		}
	}
}
