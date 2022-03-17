using FairyGUI.Utils;
using System.Collections.Generic;

namespace FairyGUI
{
	public class GearXY : GearBase, ITweenListener
	{
		public bool positionsInPercent;

		private Dictionary<string, GearXYValue> _storage;

		private GearXYValue _default;

		public GearXY(GObject owner)
		{
		}

		protected override void Init()
		{
		}

		protected override void AddStatus(string pageId, ByteBuffer buffer)
		{
		}

		public void AddExtStatus(string pageId, ByteBuffer buffer)
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

		public override void UpdateFromRelations(float dx, float dy)
		{
		}
	}
}
