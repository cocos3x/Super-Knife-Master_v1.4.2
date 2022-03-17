namespace currency
{
	public sealed class CurrencyAUD : Currency
	{
		protected override bool MathCountry(string code)
		{
			return false;
		}
	}
}
