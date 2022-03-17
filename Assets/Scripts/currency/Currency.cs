using FairyGUI;
using System.Collections.Generic;
using System.Globalization;

namespace currency
{
	public abstract class Currency
	{
		private static Currency _mCurrency;

		public short KeepPointCount;

		public string Name;

		public string CountryCode;

		public string Symbol;

		public double ExchangeRate;

		public readonly PayApp[] PayApps;

		private readonly string _trim;

		private readonly int _trimInt;

		private readonly NumberFormatInfo _numberFormatInfo;

		private static GComponent _currencyTestBtn;

		private static GTextField _currencyTestBtnText;

		private static int _index;

		private static List<string> _list;

		internal Currency(string name, string symbol, double exchangeRate, short keepPointCount, PayApp[] payApps)
		{
		}

		private void SetCountryCode(string countryCode)
		{
		}

		protected abstract bool MathCountry(string countryCode);

		protected string ToSymbolString(string money)
		{
			return "";
		}

		public static string GetSymbol()
		{
			return "";
		}

		public static string GetCountryCode()
		{
			return "";
		}

		public static PayApp[] GetPayApps()
		{
			return null;
		}

		public static double ToRateMoney(double money)
		{
			return 0.0;
		}

		public static float ToRateMoney(float money)
		{
			return 0f;
		}

		public static double ToRateMoney(int money)
		{
			return 0.0;
		}

		public static double UnRateMoney(float money)
		{
			return 0.0;
		}

		public static double UnRateMoney(int money)
		{
			return 0.0;
		}

		public static double UnRateMoney(double money)
		{
			return 0.0;
		}

		public static string ToRateMoneyString(double money, bool trim = true)
		{
			return "";
		}

		public static string ToRateMoneySymbolString(double money, bool trim = true)
		{
			return "";
		}

		public static Currency GetCurrency()
		{
			return null;
		}

		private static void GenCurrency(string code)
		{
		}

		private static void InitTestModeBtn()
		{
		}

		public static void SwitchCurrency()
		{
		}

		public override string ToString()
		{
			return "";
		}
	}
}
