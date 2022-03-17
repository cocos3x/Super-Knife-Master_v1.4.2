namespace currency
{
	public sealed class CurrencyIDR : Currency
	{
		internal CurrencyIDR()
		{
		}

		protected override bool MathCountry(string code)
		{
			return false;
		}
	}
}
