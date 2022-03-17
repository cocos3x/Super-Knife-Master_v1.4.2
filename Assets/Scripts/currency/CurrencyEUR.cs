namespace currency
{
	public sealed class CurrencyEUR : Currency
	{
		internal CurrencyEUR()
		{
		}

		protected override bool MathCountry(string code)
		{
			return false;
		}
	}
}
