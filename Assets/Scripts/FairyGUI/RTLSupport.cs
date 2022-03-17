using System.Collections.Generic;
using System.Text;

namespace FairyGUI
{
	public class RTLSupport
	{
		internal enum CharState
		{
			isolated,
			final,
			lead,
			middle
		}

		public enum DirectionType
		{
			UNKNOW,
			LTR,
			RTL,
			NEUTRAL
		}

		public static bool isRTL;

		private static bool isCharsInitialized;

		private static Dictionary<int, char[]> mapping;

		private static List<char> listFinal;

		private static List<string> listRep;

		private static StringBuilder sbRep;

		private static StringBuilder sbN;

		private static StringBuilder sbFinal;

		private static StringBuilder sbReverse;

		public static DirectionType BaseDirection => (DirectionType)null;

		public static bool IsArabicLetter(char ch)
		{
			return false;
		}

		public static string ConvertNumber(string strNumber)
		{
			return "";
		}

		public static bool ContainsArabicLetters(string text)
		{
			return false;
		}

		public static DirectionType DetectTextDirection(string text)
		{
			//IL_0003: Expected I4, but got O
			return (DirectionType)null;
		}

		private static bool CheckSeparator(char input)
		{
			return false;
		}

		private static bool CheckSpecific(char input)
		{
			return false;
		}

		private static bool _CheckSoundmark(char ch)
		{
			return false;
		}

		public static string DoMapping(string input)
		{
			return "";
		}

		public static string ConvertLineL(string source)
		{
			return "";
		}

		public static string ConvertLineR(string source)
		{
			return "";
		}

		private static string _Reverse(string source)
		{
			return "";
		}

		private static void InitChars()
		{
		}

		private static bool _IsNeutrality(char uc)
		{
			return false;
		}

		private static bool _IsEndPunctuation(char uc, char nextChar)
		{
			return false;
		}

		private static DirectionType _GetDirection(char uc, char nextChar, DirectionType ePre, DirectionType eBase)
		{
			//IL_0003: Expected I4, but got O
			return (DirectionType)null;
		}

		private static bool _IsBracket(char uc)
		{
			return false;
		}

		private static char _ProcessBracket(char uc)
		{
			return '\0';
		}
	}
}
