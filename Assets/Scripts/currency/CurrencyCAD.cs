namespace currency
{
	public sealed class CurrencyCAD : Currency
	{
		internal CurrencyCAD()
		{
		}

		protected override bool MathCountry(string code)
		{
			return false;
		}
	}
}
