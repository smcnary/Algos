using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
	public class Timing
	{
		TimeSpan startingTime;
		TimeSpan duration;

		public Timing()
		{
			startingTime = new TimeSpan(0);
			duration = new TimeSpan(0);
		}

		public void StopTime()
		{
			duration =
					Process.GetCurrentProcess().Threads[0].UserProcessorTime.Subtract(startingTime);
		}

		public void startTime() {
			GC.Collect();
			GC.WaitForPendingFinalizers();
			startingTime =
					Process.GetCurrentProcess().Threads[0].
					        UserProcessorTime;
		}
		public TimeSpan Result() {
			return duration;
		}


		class Chapter1
		{
			//static void Main() {
			//	//int[] nums = new int[100000];
			//	//BuildArray(nums);
			//	//TimeSpan startTime;
			//	//TimeSpan duration;
			//	//startTime =
			//	//		Process.GetCurrentProcess().Threads[0].
			//	//		        UserProcessorTime;
			//	//DisplayNums(nums);
			//	//duration =
			//	//		Process.GetCurrentProcess().Threads[0].
			//	//		        UserProcessorTime.
			//	//		        Subtract(startTime);
			//	//Console.WriteLine("Time:"+ duration.TotalSeconds);

			//	//Console.ReadLine();


			//	int[,] grades = new int[,] {{1, 82, 74, 89, 100},
			//			{2, 93, 96, 85, 86},
			//			{3, 83, 72, 95, 89},
			//			{4, 91, 98, 79, 88}};
			//	int last_grade = grades.GetUpperBound(1);
			//	double average = 0.0;
			//	int total;
			//	int last_student = grades.GetUpperBound(0);
			//	for(int row = 0; row <= last_student; row++) {
			//		total = 0;
			//		for (int col = 0; col <= last_grade; col++)
			//			total += grades[row, col];
			//		average = total / last_grade;
			//		Console.WriteLine("Average:"+ average);
			//	}
			//}
			static void BuildArray(int[] arr) {
				for(int i = 0; i <= 99999; i++)
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
	}
}
