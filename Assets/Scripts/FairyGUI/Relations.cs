using FairyGUI.Utils;
using System.Collections.Generic;

namespace FairyGUI
{
	public class Relations
	{
		private GObject _owner;

		private List<RelationItem> _items;

		public GObject handling;

		public bool isEmpty => false;

		public Relations(GObject owner)
		{
		}

		public void Add(GObject target, RelationType relationType)
		{
		}

		public void Add(GObject target, RelationType relationType, bool usePercent)
		{
		}

		public void Remove(GObject target, RelationType relationType)
		{
		}

		public bool Contains(GObject target)
		{
			return false;
		}

		public void ClearFor(GObject target)
		{
		}

		public void ClearAll()
		{
		}

		public void CopyFrom(Relations source)
		{
		}

		public void Dispose()
		{
		}

		public void OnOwnerSizeChanged(float dWidth, float dHeight, bool applyPivot)
		{
		}

		public void Setup(ByteBuffer buffer, bool parentToChild)
		{
		}
	}
}
