using Core.skill;
using ExcelConfig;
using Master;
using System.Collections.Generic;

namespace Presenter
{
	public class SkillPresenter : Presenter<SkillPresenter>
	{
		public List<LvAttrConfigItem> tapConfig => null;

		public List<LvAttrConfigItem> normalConfig => null;

		internal override void OnInit()
		{
		}

		public List<LvAttrConfigItem> GetLevelAttr(int knifeId)
		{
			return null;
		}

		public static SkillId GetSkillIdByString(string str)
		{
			//IL_0003: Expected I4, but got O
			return (SkillId)null;
		}
	}
}
