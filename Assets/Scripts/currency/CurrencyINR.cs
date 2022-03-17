namespace currency
{
	public sealed class CurrencyINR : Currency
	{
		internal CurrencyINR()
		{
		}

		protected override bool MathCountry(string code)
		{
			return false;
		}
	}
}
