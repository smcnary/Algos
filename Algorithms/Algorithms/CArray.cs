using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
	public class CArray
	{
		private int [] arr;
		private int upper;
		private int numElements;
		public CArray(int size) {
			arr = new int[size];
			upper = size-1;
			numElements = 0;
		}

		public void Insert(int item) {
			arr[numElements] = item;
			numElements++;
		}

		public void DisplayElements() {
			for(int i = 0; i <= upper; i++)
				Console.Write(arr[i] + " ");
			Console.ReadLine();
		}
		public void Clear() {
			for(int i = 0; i <= upper; i++)
				arr[i] = 0;
			numElements = 0;
		}

		public void BubbleSort() {
			int temp;
			for(int outer = upper; outer >= 1; outer--) {
				for(int inner = 0; inner <= outer-1;inner++) {
					if ((int)arr[inner] > arr[inner+1]) {
						temp = arr[inner];
						arr[inner] = arr[inner+1];
						arr[inner+1] = temp;
					}
				}
				this.DisplayElements();
			}
		}

		static void Main() {
			CArray nums = new CArray(10);
			Random rnd = new Random(100);
			for(int i = 0; i < 10; i++)
				nums.Insert((int)(rnd.NextDouble() * 100));
			Console.WriteLine("Before sorting: ");
			nums.DisplayElements();
			Console.WriteLine("During sorting: ");
			nums.BubbleSort();
			Console.WriteLine("After sorting: ");
			nums.DisplayElements();

			Console.ReadLine();
		}
	}
}
