using System;
using System.Collections.Generic;
using UnityEngine;

namespace FairyGUI
{
	public class CustomEase
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Comparison<Vector2> _003C_003E9__4_0;

			internal int _003CCreate_003Eb__4_0(Vector2 p1, Vector2 p2)
			{
				return 0;
			}
		}

		private Vector2[] _points;

		private int _pointDensity;

		private static GPath helperPath;

		public CustomEase(int pointDensity = 200)
		{
		}

		public void Create(IEnumerable<GPathPoint> pathPoints)
		{
		}

		public float Evaluate(float time)
		{
			return 0f;
		}
	}
}
