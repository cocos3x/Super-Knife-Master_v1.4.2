using Master;
using System.Collections.Generic;

namespace ExcelConfig
{
	public class JsonMeta : SJsonMeta
	{
		private static Dictionary<int, KnifeLocalConfig> _003CknifeConfig_003Ek__BackingField;

		private static List<BuffConfigItem> _003CbuffConfig_003Ek__BackingField;

		private static Dictionary<string, SkillConfigItem> _003CskillConfig_003Ek__BackingField;

		private static Dictionary<string, List<LvAttrConfigItem>> _003ClevelAttrConfig_003Ek__BackingField;

		private static Dictionary<int, TrailConfig> _003CtrailConfig_003Ek__BackingField;

		public static Dictionary<int, KnifeLocalConfig> knifeConfig
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public static List<BuffConfigItem> buffConfig
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public static Dictionary<string, SkillConfigItem> skillConfig
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public static Dictionary<string, List<LvAttrConfigItem>> levelAttrConfig
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public static Dictionary<int, TrailConfig> trailConfig
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public static void LoadLocalConfig()
		{
		}
	}
}
