namespace currency
{
	public sealed class CurrencyGBP : Currency
	{
		internal CurrencyGBP()
		{
		}

		protected override bool MathCountry(string code)
		{
			return false;
		}
	}
}
