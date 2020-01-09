using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
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


		class Chapter1
		{
			static void Main() {
				int[] nums = new int[1000000];
				BuildArray(nums);
				TimeSpan startTime;
				TimeSpan duration;
				startTime =
						Process.GetCurrentProcess().Threads[0].
						        UserProcessorTime;
				DisplayNums(nums);
				duration =
						Process.GetCurrentProcess().Threads[0].
						        UserProcessorTime.
						        Subtract(startTime);
				Console.WriteLine("Time:"+ duration.TotalSeconds);

				Console.ReadLine();
			}
			static void BuildArray(int[] arr) {
				for(int i = 0; i <= 999999; i++)
					arr[i] = i;
			}
			static void DisplayNums(int[] arr) {
				for(int i = 0; i <= arr.GetUpperBound(0); i++)
					Console.Write(arr[i] + " ");
			}

			static void Swap<T>(ref T val1, ref T val2)
			{
				T temp;
				temp = val1;
				val1 = val2;
				val2 = temp;
				
			}

			
		}

		public class Node<T>
		{
			private T data;
			private Node<T> link;

			public Node(T data, Node<T> link)
			{
				this.data = data;
				this.link = link;
			}
		}


	}
	
}
