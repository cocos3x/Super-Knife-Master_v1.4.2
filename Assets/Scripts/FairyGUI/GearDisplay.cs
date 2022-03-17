using FairyGUI.Utils;

namespace FairyGUI
{
	public class GearDisplay : GearBase
	{
		private string[] _003Cpages_003Ek__BackingField;

		private int _visible;

		private uint _displayLockToken;

		public string[] pages
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool connected => false;

		public GearDisplay(GObject owner)
		{
		}

		protected override void AddStatus(string pageId, ByteBuffer buffer)
		{
		}

		protected override void Init()
		{
		}

		public override void Apply()
		{
		}

		public override void UpdateState()
		{
		}

		public uint AddLock()
		{
			return 0u;
		}

		public void ReleaseLock(uint token)
		{
		}
	}
}
