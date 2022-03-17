namespace currency
{
	public sealed class CurrencyJPY : Currency
	{
		internal CurrencyJPY()
		{
		}

		protected override bool MathCountry(string code)
		{
			return false;
		}
	}
}
