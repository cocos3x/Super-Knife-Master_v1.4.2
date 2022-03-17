namespace currency
{
	public class CurrencyPHP : Currency
	{
		internal CurrencyPHP()
		{
		}

		protected override bool MathCountry(string code)
		{
			return false;
		}
	}
}
