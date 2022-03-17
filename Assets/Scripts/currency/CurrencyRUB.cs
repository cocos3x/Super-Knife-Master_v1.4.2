namespace currency
{
	public class CurrencyRUB : Currency
	{
		internal CurrencyRUB()
		{
		}

		protected override bool MathCountry(string code)
		{
			return false;
		}
	}
}
