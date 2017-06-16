using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScienceComputation {
	public static class DigitalNotation {
		/// <summary>
		/// 通过静态构造器生成字符表
		/// </summary>
		static DigitalNotation( ) {
			_charMappingToDigit.Add( '0' , 0 );
			_charMappingToDigit.Add( '1' , 1 );
			_charMappingToDigit.Add( '2' , 2 );
			_charMappingToDigit.Add( '3' , 3 );
			_charMappingToDigit.Add( '4' , 4 );
			_charMappingToDigit.Add( '5' , 5 );
			_charMappingToDigit.Add( '6' , 6 );
			_charMappingToDigit.Add( '7' , 7 );
			_charMappingToDigit.Add( '8' , 8 );
			_charMappingToDigit.Add( '9' , 9 );
			_charMappingToDigit.Add( 'A' , 10 );
			_charMappingToDigit.Add( 'B' , 11 );
			_charMappingToDigit.Add( 'C' , 12 );
			_charMappingToDigit.Add( 'D' , 13 );
			_charMappingToDigit.Add( 'E' , 14 );
			_charMappingToDigit.Add( 'F' , 15 );
			_charMappingToDigit.Add( 'a' , 10 );
			_charMappingToDigit.Add( 'b' , 11 );
			_charMappingToDigit.Add( 'c' , 12 );
			_charMappingToDigit.Add( 'd' , 13 );
			_charMappingToDigit.Add( 'e' , 14 );
			_charMappingToDigit.Add( 'f' , 15 );
		}
		/// <summary>
		/// 字符表（字符到数字的映射）
		/// </summary>
		private static SortedList<char , int> _charMappingToDigit = new SortedList<char , int>( 22 );
		/// <summary>
		/// 字符转二进制数字
		/// </summary>
		/// <param name="char"></param>
		/// <returns></returns>
		private static int CharToBit( char @char ) {
			if (@char == '0' || @char == '1') {
				return DigitalNotation._charMappingToDigit[ @char ];
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
				return DigitalNotation._charMappingToDigit[ @char ];
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
			if (@char >= '0' && @char <= '9' || @char >= 'A' && @char <= 'F' || @char >= 'a' && @char <= 'f') {
				return DigitalNotation._charMappingToDigit[ @char ];
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
		public static string BinaryToSByteParsec( string binary ) {
			sbyte sb = (sbyte)(Math.Pow( 2 , 2 ) * (sbyte)Math.Pow( 2 , 2 ));
			Func<int , int , sbyte , sbyte> calc = null;
			calc = ( index , pow , result ) =>
				index < binary.Length ? calc( index + 1 , pow - 1 , result + (sbyte)(CharToBit( binary[ index ] ) * (int)Math.Pow( 2 , pow )) ) : result;
			return calc( 0 , binary.Length - 1 , 0 ).ToString( );
		}
		/// <summary>
		/// 二进制转换十进制
		/// </summary>
		/// <param name="binary"></param>
		/// <returns></returns>
		public static string BinaryToByteParsec( string binary ) {
			Func<int , int , int , int> calc = null;
			calc = ( index , pow , result ) =>
				index < binary.Length ? calc( index + 1 , pow - 1 , result + CharToBit( binary[ index ] ) * (int)Math.Pow( 2 , pow ) ) : result;
			return calc( 0 , binary.Length - 1 , 0 ).ToString( );
		}
		/// <summary>
		/// 二进制转换十进制
		/// </summary>
		/// <param name="binary"></param>
		/// <returns></returns>
		public static string BinaryToInt32Parsec( string binary ) {
			Func<int , int , int , int> calc = null;
			calc = ( index , pow , result ) =>
				index < binary.Length ? calc( index + 1 , pow - 1 , result + CharToBit( binary[ index ] ) * (int)Math.Pow( 2 , pow ) ) : result;
			return calc( 0 , binary.Length - 1 , 0 ).ToString( );
		}
		/// <summary>
		/// 二进制转换十进制
		/// </summary>
		/// <param name="binary"></param>
		/// <returns></returns>
		public static string BinaryToInt32Parsec( string binary ) {
			Func<int , int , int , int> calc = null;
			calc = ( index , pow , result ) =>
				index < binary.Length ? calc( index + 1 , pow - 1 , result + CharToBit( binary[ index ] ) * (int)Math.Pow( 2 , pow ) ) : result;
			return calc( 0 , binary.Length - 1 , 0 ).ToString( );
		}
		/// <summary>
		/// 二进制转换十进制
		/// </summary>
		/// <param name="binary"></param>
		/// <returns></returns>
		public static string BinaryToInt32Parsec( string binary ) {
			Func<int , int , int , int> calc = null;
			calc = ( index , pow , result ) =>
				index < binary.Length ? calc( index + 1 , pow - 1 , result + CharToBit( binary[ index ] ) * (int)Math.Pow( 2 , pow ) ) : result;
			return calc( 0 , binary.Length - 1 , 0 ).ToString( );
		}
		/// <summary>
		/// 二进制转换十进制
		/// </summary>
		/// <param name="binary"></param>
		/// <returns></returns>
		public static string BinaryToInt32Parsec( string binary ) {
			Func<int , int , int , int> calc = null;
			calc = ( index , pow , result ) =>
				index < binary.Length ? calc( index + 1 , pow - 1 , result + CharToBit( binary[ index ] ) * (int)Math.Pow( 2 , pow ) ) : result;
			return calc( 0 , binary.Length - 1 , 0 ).ToString( );
		}
		/// <summary>
		/// 二进制转换十进制
		/// </summary>
		/// <param name="binary"></param>
		/// <returns></returns>
		public static string BinaryToInt32Parsec( string binary ) {
			Func<int , int , int , int> calc = null;
			calc = ( index , pow , result ) =>
				index < binary.Length ? calc( index + 1 , pow - 1 , result + CharToBit( binary[ index ] ) * (int)Math.Pow( 2 , pow ) ) : result;
			return calc( 0 , binary.Length - 1 , 0 ).ToString( );
		}
		/// <summary>
		/// 二进制转换十进制
		/// </summary>
		/// <param name="binary"></param>
		/// <returns></returns>
		public static string BinaryToInt32Parsec( string binary ) {
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
		public static string Int32ToBinaryParsec( string @decimal ) {
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
