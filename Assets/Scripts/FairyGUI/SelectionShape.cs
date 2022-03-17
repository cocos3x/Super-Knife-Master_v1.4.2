using System.Collections.Generic;
using UnityEngine;

namespace FairyGUI
{
	public class SelectionShape : DisplayObject, IMeshFactory
	{
		public readonly List<Rect> rects;

		public Color color
		{
			get
			{
				return (Color)null;
			}
			set
			{
			}
		}

		public void Refresh()
		{
		}

		public void Clear()
		{
		}

		public void OnPopulateMesh(VertexBuffer vb)
		{
		}

		protected override DisplayObject HitTest()
		{
			return null;
		}
	}
}
