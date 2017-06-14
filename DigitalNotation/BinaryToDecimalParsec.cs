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
			Func<int , int , int , int> calc = null;
			calc = ( index , pow , result ) =>
				index < binary.Length ? calc( index + 1 , pow - 1 , result + binary[ index ] * (int)Math.Pow( 2 , pow ) ) : result;
			return calc( 0 , binary.Length - 1 , 0 ).ToString( );
		}
		/// <summary>
		/// 十进制转换二进制
		/// </summary>
		/// <param name="decimal"></param>
		/// <returns></returns>
		public static string DecimalToBinaryParsec( string @decimal ) {
			Func<int , string> calc = null;
			string result = String.Empty;
			int rem;
			calc = ( div ) => {
				div = Math.DivRem( div , 2 , out rem );
				result += rem.ToString( );
				return div == 0 ? result.Reverse( ).ToString( ) : calc( div );
			};
			return calc( Convert.ToInt32( @decimal ) );
		}
	}
}
