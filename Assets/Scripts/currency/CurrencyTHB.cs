namespace currency
{
	public class CurrencyTHB : Currency
	{
		internal CurrencyTHB()
		{
		}

		protected override bool MathCountry(string code)
		{
			return false;
		}
	}
}
