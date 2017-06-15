using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScienceComputation {
	public static class DigitalNotation {
		static DigitalNotation( ) {
			_charMappingToInt.Add( '0' , 0 );
			_charMappingToInt.Add( '1' , 1 );
			_charMappingToInt.Add( '2' , 2 );
			_charMappingToInt.Add( '3' , 3 );
			_charMappingToInt.Add( '4' , 4 );
			_charMappingToInt.Add( '5' , 5 );
			_charMappingToInt.Add( '6' , 6 );
			_charMappingToInt.Add( '7' , 7 );
			_charMappingToInt.Add( '8' , 8 );
			_charMappingToInt.Add( '9' , 9 );
			_charMappingToInt.Add( 'A' , 10 );
			_charMappingToInt.Add( 'B' , 11 );
			_charMappingToInt.Add( 'C' , 12 );
			_charMappingToInt.Add( 'D' , 13 );
			_charMappingToInt.Add( 'E' , 14 );
			_charMappingToInt.Add( 'F' , 15 );
			_charMappingToInt.Add( 'a' , 10 );
			_charMappingToInt.Add( 'b' , 11 );
			_charMappingToInt.Add( 'c' , 12 );
			_charMappingToInt.Add( 'd' , 13 );
			_charMappingToInt.Add( 'e' , 14 );
			_charMappingToInt.Add( 'f' , 15 );
		}
		private static SortedList<char , int> _charMappingToInt = new SortedList<char , int>( 22 );
		/// <summary>
		/// 字符转二进制数字
		/// </summary>
		/// <param name="char"></param>
		/// <returns></returns>
		private static int CharToBit( char @char ) {
			if (@char == '0' || @char == '1') {
				return DigitalNotation._charMappingToInt[ @char ];
			}
			else {
				throw new ArgumentException( "二进制数只能是 0 和 1." );
			}
		}
		/// <summary>
		/// 字符转十进制数字
		/// </summary>
		/// <param name="char"></param>
		/// <returns></returns>
		private static int CharToDec( char @char ) {
			if (@char >= '0' && @char <= '9') {
				return DigitalNotation._charMappingToInt[ @char ];
			}
			else {
				throw new ArgumentException( "十进制数只能是 0 到 9." );
			}
		}
		/// <summary>
		/// 字符转十六进制数字
		/// </summary>
		/// <param name="char"></param>
		/// <returns></returns>
		private static int CharToHex( char @char ) {
			if (@char >= '0' && @char <= '9'|| @char >= 'A' && @char <= 'F'|| @char >= 'a' && @char <= 'f') {
				return DigitalNotation._charMappingToInt[ @char ];
			}
			else {
				throw new ArgumentException( "十六进制数只能是 0 到 F." );
			}
		}
		/// <summary>
		/// 二进制转换十进制
		/// </summary>
		/// <param name="binary"></param>
		/// <returns></returns>
		public static string BinaryToDecimalParsec( string binary ) {
			Func<int , int , int , int> calc = null;
			calc = ( index , pow , result ) =>
				index < binary.Length ? calc( index + 1 , pow - 1 , result + CharToBit( binary[ index ] ) * (int)Math.Pow( 2 , pow ) ) : result;
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
