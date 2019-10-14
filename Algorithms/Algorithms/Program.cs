using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			int[] a = { 3, 0, 2, 5, -1, 4, 1 };


			Algos algos = new Algos();

			//Fastest to slowest
			algos.RadixSort();

			algos.IntArraySelectionSort(a);

			algos.IntArrayBubbleSort(a);


		}

		





	}
}