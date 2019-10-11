using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
	class Program
	{
		static void Main(string[] args)
		{
			BubbleSort();
		}

		
		public static void ExchangeDataTypes (int[] data, int m, int n)
		{
			int temporary = data [m];
			data [m] = data [n];
			data [n] = temporary;
		}
		
		private static void BubbleSort()
		{
			int[] a = { 3, 0, 2, 5, -1, 4, 1 }; 
			int t; 
			Console.WriteLine("Original array :");
			foreach (int aa in a)                       
				Console.Write(aa + " ");                     
			for (int passLength = a.Length -2; passLength >= 0; passLength--)
			{
				for (int i = 0; i <= passLength; i++)
				{
					if (a[i] > a[i + 1])
					{
						t = a[i + 1];
						a[i + 1] = a[i];
						a[i] = t;
					}
				} 
			}
			Console.WriteLine("\n"+"Sorted array :");
			foreach (int aa in a)                       
				Console.Write(aa + " ");
			Console.Write("\n"); 
		}
	}
}
