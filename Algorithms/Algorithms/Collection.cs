using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
	public class Collection : CollectionBase
	{
		public void Add(Object item)
		{
			InnerList.Add(item);
		}

		public void Remove(Object item)
		{
			InnerList.Remove(item);
		}

		public new void Clear()
		{
			InnerList.Clear();
		}

		public new int Count() => InnerList.Count;
	}

	public class T { }
}
