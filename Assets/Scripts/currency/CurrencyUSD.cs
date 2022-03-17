namespace currency
{
	public class CurrencyUSD : Currency
	{
		internal CurrencyUSD()
		{
		}

		protected override bool MathCountry(string code)
		{
			return false;
		}
	}
}
