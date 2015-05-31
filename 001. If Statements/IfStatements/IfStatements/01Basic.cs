using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatements
{
	public class _01Basic
	{
		/// <summary>
		/// This method takes a String <paramref name="number"/> and returns its number representation of it up to 10
		/// i.e. if you send in "One" it will return 1
		/// </summary>
		/// <param name="number">The string number to parse</param>
		/// <returns>0-10 depending on the number passed</returns>
		public int ConvertToNumber(String number)
		{
			if(number == "Zero")
			{
				return 0;
			}
			// One
			// Two
			// Three
			// Four
			// Five
			// Six
			// Seven
			// Eight
			// Nine
			// Ten

			return -1; // number is not supported
		}
	}
}
