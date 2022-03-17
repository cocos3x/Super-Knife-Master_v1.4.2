using Master;
using SaveData;

namespace Presenter
{
	public class GuidePresenter : Presenter<GuidePresenter>
	{
		private SDataOption<GameData> _option;

		private GameData _data;

		public int guideId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		internal override void OnInit()
		{
		}
	}
}
