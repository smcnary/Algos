using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
	public class CArray
	{
		private readonly int [] _arr;
		private readonly int _upper;
		private int _numElements;
		public CArray(int size) {
			_arr = new int[size];
			_upper = size-1;
			_numElements = 0;
		}

		public void Insert(int item) {
			_arr[_numElements] = item;
			_numElements++;
		}

		public void DisplayElements() {
			for(int i = 0; i <= _upper; i++)
				Console.Write(_arr[i] + " ");
			Console.ReadLine();
		}
		public void Clear() {
			for(int i = 0; i <= _upper; i++)
				_arr[i] = 0;
			_numElements = 0;
		}

		public void SelectionSort() {
			//initalize values that change throughout the algo.
			int min, temp;

			//Two arrays
			//Outer one starts at 0;  continues until it reaches the limit of the array; 
			//Inner array starts outer + 1; and continues to iterate through outer + 1 until it reaches the limit of the array (upper)
			//min is initialized to outer, which is 0;
			for(int outer = 0; outer <= _upper; outer++) {
				min = outer;
				for(int inner = outer + 1; inner <= _upper; inner++)
						//if the value of _arr[inner] < _arr[min]
						//
					if (_arr[inner] < _arr[min])
						min = inner;
				temp = _arr[outer];
				_arr[outer] = _arr[min];
				_arr[min] = temp;
			}
		}

		public void BubbleSort() {
			int temp;
			for(int outer = _upper; outer >= 1; outer--) {
				for(int inner = 0; inner <= outer-1;inner++) {
					if ((int)_arr[inner] > _arr[inner+1]) {
						temp = _arr[inner];
						_arr[inner] = _arr[inner+1];
						_arr[inner+1] = temp;
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
			nums.SelectionSort();
			Console.WriteLine("After sorting: ");
			nums.DisplayElements();

			Console.ReadLine();
		}
	}
}
