using FairyGUI.Utils;
using System.Collections.Generic;

namespace FairyGUI
{
	public class GearLook : GearBase, ITweenListener
	{
		private Dictionary<string, GearLookValue> _storage;

		private GearLookValue _default;

		public GearLook(GObject owner)
		{
		}

		protected override void Init()
		{
		}

		protected override void AddStatus(string pageId, ByteBuffer buffer)
		{
		}

		public override void Apply()
		{
		}

		public void OnTweenStart(GTweener tweener)
		{
		}

		public void OnTweenUpdate(GTweener tweener)
		{
		}

		public void OnTweenComplete(GTweener tweener)
		{
		}

		public override void UpdateState()
		{
		}
	}
}
