namespace currency
{
	public sealed class CurrencyMAX : Currency
	{
		internal CurrencyMAX()
		{
		}

		protected override bool MathCountry(string code)
		{
			return false;
		}
	}
}
