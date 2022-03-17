namespace currency
{
	public class CurrencyMYR : Currency
	{
		internal CurrencyMYR()
		{
		}

		protected override bool MathCountry(string code)
		{
			return false;
		}
	}
}
