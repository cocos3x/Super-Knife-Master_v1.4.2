namespace Master
{
	public abstract class Presenter<T> : SPresenter where T : SPresenter
	{
		private static T _instance;

		public static T Instance => null;
	}
}
