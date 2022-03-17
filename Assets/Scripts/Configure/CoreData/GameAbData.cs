using Newtonsoft.Json.Linq;

namespace Configure.CoreData
{
	public class GameAbData
	{
		public const string CoreConfigAbKey = "numerical_version";

		public const string AbServerEid = "eid";

		public const string AbServerGame = "ab_ad_interval";

		public const string AbServerRate = "fun_rate_switch";

		public const string AbServerAudit = "audit_mode";

		public static readonly string[] AbArray;

		public int Mode;

		public int fun_rate_switch;

		public int fun_rate_state;

		public int audit_mode_switch;

		public int audit_mode_state;

		public int game_gold_switch;

		public int buy_buff_time;

		public int buff_activation;

		public string boss_level;

		public static JObject _testJson;

		public bool openCollect => false;

		public bool openMoney => false;

		public bool openRate => false;

		public bool openAuditMode => false;

		public bool openBuffTips => false;

		public override string ToString()
		{
			return "";
		}
	}
}
