using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScienceComputation {
	public static class DigitalNotation {
		/// <summary>
		/// 二进制转换十进制
		/// </summary>
		/// <param name="binary"></param>
		/// <returns></returns>
		public static string BinaryToDecimalParsec( string binary ) {
			double result = 0.0;
			for (int index = 0, pow = binary.Length - 1 ; index < binary.Length ; index++) {
				result += Math.Pow( binary[ index ] , pow );
			}
			return result.ToString( );
		}
	}
}
