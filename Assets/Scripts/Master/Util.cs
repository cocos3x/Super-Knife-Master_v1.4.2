using System;
using System.Collections.Generic;

namespace Master
{
	public static class Util
	{
		public static bool IsLog;

		public static bool IsTestMode;

		private static bool s_isCheckDotChar;

		private static char s_dotChar;

		private static char[] UnitList;

		private static bool s_isInit1970;

		private static DateTime s_dateTime1970;

		private static readonly string[] s_timeFormatStrList;

		private static readonly string[] s_timeFormatStrList2;

		public static bool IsIOS => false;

		public static bool IsAndroid => false;

		public static long localTimeStamp => 0L;

		public static long localTimeStampMill => 0L;

		public static string ToLogMessage(string tag, params object[] value)
		{
			return "";
		}

		public static void LogDebug(string tag, params object[] value)
		{
		}

		public static void HideMeshRenderByTag(string tag)
		{
		}

		public static string NumberToString(double value, int keepCount)
		{
			return "";
		}

		public static string NumberToString(double value, int keepCount, bool isTrimZero)
		{
			return "";
		}

		public static char GetDotChar()
		{
			return '\0';
		}

		public static string ToThousandsString(long v)
		{
			return "";
		}

		public static string ToThousandDecimalsString(double v)
		{
			return "";
		}

		public static string CurrencyToRateMoneyString(double value, int keepCount = 3)
		{
			return "";
		}

		public static string CurrencyToRateMoneyString(double value, int keepCount, bool trim)
		{
			return "";
		}

		public static string ToKMBTUnitString(long v)
		{
			return "";
		}

		public static string ToKMBTUnitString(string numberStr)
		{
			return "";
		}

		public static long KMBTStringToLong(string str)
		{
			return 0L;
		}

		public static DateTime TimeStampToDate(long secondTick)
		{
			return (DateTime)null;
		}

		public static long DateToTimeStamp(DateTime date)
		{
			return 0L;
		}

		public static long DateToTimeStampMill(DateTime date)
		{
			return 0L;
		}

		public static string TimeStampFormat(long timeStamp)
		{
			return "";
		}

		public static string TimeStampFormatDate(long timeStamp)
		{
			return "";
		}

		public static string FormatSeconds(long seconds, int maxCount = 3, int formatType = 0)
		{
			return "";
		}

		public static void FormatSeconds(long seconds, out string hourStr, out string minStr, out string secStr)
		{
		}

		public static void FormatSeconds(long seconds, out string minStr, out string secStr)
		{
		}

		public static string ListToStr<T>(IEnumerable<T> values)
		{
			return "";
		}

		public static string List2ToStr<T>(T[][] values, int index)
		{
			return "";
		}

		public static bool HasArrayKey(int[] arr, int cashIndex)
		{
			return false;
		}

		public static string ToUsdStrAuto(long value)
		{
			return "";
		}

		public static void Shuffle<T>(this IList<T> list)
		{
		}

		public static bool EqualsIgnoreCase(this string str1, string str2)
		{
			return false;
		}

		public static T TryGetArgs<T>(object[] args, int index, T defaultValue)
		{
			return (T)null;
		}

		public static string TimeLogStr(long timeSecond)
		{
			return "";
		}

		public static int Int32StrToNum(string str)
		{
			return 0;
		}
	}
}
