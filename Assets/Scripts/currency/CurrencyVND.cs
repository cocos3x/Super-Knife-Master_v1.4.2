namespace currency
{
	public class CurrencyVND : Currency
	{
		internal CurrencyVND()
		{
		}

		protected override bool MathCountry(string code)
		{
			return false;
		}
	}
}
