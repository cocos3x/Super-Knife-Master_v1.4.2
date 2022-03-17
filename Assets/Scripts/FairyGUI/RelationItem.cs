using System.Collections.Generic;
using UnityEngine;

namespace FairyGUI
{
	internal class RelationItem
	{
		private GObject _owner;

		private GObject _target;

		private List<RelationDef> _defs;

		private Vector4 _targetData;

		public GObject target
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool isEmpty => false;

		public RelationItem(GObject owner)
		{
		}

		public void Add(RelationType relationType, bool usePercent)
		{
		}

		public void InternalAdd(RelationType relationType, bool usePercent)
		{
		}

		public void Remove(RelationType relationType)
		{
		}

		public void CopyFrom(RelationItem source)
		{
		}

		public void Dispose()
		{
		}

		public void ApplyOnSelfSizeChanged(float dWidth, float dHeight, bool applyPivot)
		{
		}

		private void ApplyOnXYChanged(RelationDef info, float dx, float dy)
		{
		}

		private void ApplyOnSizeChanged(RelationDef info)
		{
		}

		private void AddRefTarget(GObject target)
		{
		}

		private void ReleaseRefTarget(GObject target)
		{
		}

		private void __targetXYChanged(EventContext context)
		{
		}

		private void __targetSizeChanged(EventContext context)
		{
		}
	}
}
