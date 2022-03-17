namespace FairyGUI
{
	public interface IUISource
	{
		string fileName
		{
			get;
			set;
		}

		bool loaded
		{
			get;
		}

		void Load(UILoadCallback callback);
	}
}
