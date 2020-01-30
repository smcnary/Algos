using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
	public class LeetCodes
	{
		public string RemoveVowels(string s)
		{
			var vowels = new HashSet<char> {'a', 'e', 'i', 'o', 'u'};
			return new string(s.Where(x => !vowels.Contains(x)).ToArray());
		}

		public string DefangIPaddr(string address) => address.Replace(".", "[.]");

		public int FindNumbers(int[] nums)
		{
			int amtOfEvenDigits = 0;
			foreach (int t in nums)
			{
				int count = t.ToString().Length;
				amtOfEvenDigits = count >= 2 && (double) count % 2 == 0 ? amtOfEvenDigits += 1 : amtOfEvenDigits;
			}
			return amtOfEvenDigits;
		}

		public int SubtractProductAndSum(int n)
		{
			int result = 0;
			string[] splitDigitsArray;
			if (n.ToString().Length > 0)
			{
				splitDigitsArray = n.ToString().Split();
			}

			//foreach (var v in splitDigitsArray)
			//{
			//	result += v
			//}
			return result;
		}
	}
}
