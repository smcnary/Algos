﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			int[] a = { 3, 0, 2, 5, -1, 4, 1 };

			IntArrayBubbleSort(a);
			BubbleSort(a);

			IntArraySelectionSort(a);
		}

		public static void Exchange(int[] data, int m, int n)
		{
			int temporary = data[m];
			data[m] = data[n];
			data[n] = temporary;
		}

		public static void IntArrayBubbleSort(int[] data)
		{
			int i, j;
			int N = data.Length;

			for (j = N - 1; j > 0; j--)
			{
				for (i = 0; i < j; i++)
				{
					if (data[i] > data[i + 1])
						Exchange(data, i, i + 1);
				}
			}
		}

		public static int IntArrayMin(int[] data, int start)
		{
			int minPos = start;
			for (int pos = start + 1; pos < data.Length; pos++)
				if (data[pos] < data[minPos])
					minPos = pos;
			return minPos;
		}

		public static void IntArraySelectionSort(int[] data)
		{
			int i;
			int N = data.Length;

			for (i = 0; i < N - 1; i++)
			{
				int k = IntArrayMin(data, i);
				if (i != k)
					Exchange(data, i, k);
			}
		}

		private static void BubbleSort(int[] a)
		{
			int t;
			Console.WriteLine("Original array :");
			foreach (int aa in a)
				Console.Write(aa + " ");
			for (int passLength = a.Length - 2; passLength >= 0; passLength--)
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
			Console.WriteLine("\n" + "Sorted array :");
			foreach (int aa in a)
				Console.Write(aa + " ");
			Console.Write("\n");
		}


		public void RadixSort()
		{
			List<string> allnums = new List<string>();
			int numOfDigits = 0;

			Dictionary<string, List<string>> buckets = new Dictionary<string, List<string>>
			{
					{ "0", new List<string>() },
					{ "1", new List<string>() },
					{ "2", new List<string>() },
					{ "3", new List<string>() },
					{ "4", new List<string>() },
					{ "5", new List<string>() },
					{ "6", new List<string>() },
					{ "7", new List<string>() },
					{ "8", new List<string>() },
					{ "9", new List<string>() }
			};
			
			for(int sortingDigit = numOfDigits-1; sortingDigit >= 0; sortingDigit--) // sort by least important digit to most
			{
				
				allnums.ForEach(n => // pass through every number in the list
				{
					buckets[n.Substring(sortingDigit, 1)].Add(n); // add each number to the correct bucket for the current digit
				});
				allnums.Clear(); // empty the main list
				buckets.ToList().ForEach(bucket => // for each bucket in order
				{
					allnums.AddRange(bucket.Value); // dump them back into the main list
					bucket.Value.Clear(); // emptying the bucket
				});
			}
		}





	}
}