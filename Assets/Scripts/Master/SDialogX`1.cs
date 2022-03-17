namespace Master
{
	public abstract class SDialogX<T> : SDialog where T : SDialog
	{
		public static bool isShowing => false;

		public static T OpenDialog(params object[] args)
		{
			return null;
		}
	}
}
