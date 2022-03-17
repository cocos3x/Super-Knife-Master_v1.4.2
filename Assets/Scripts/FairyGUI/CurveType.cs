using System;
using UnityEngine;

namespace FairyGUI
{
	[Serializable]
	public struct GPathPoint
	{
		public enum CurveType
		{
			CRSpline,
			Bezier,
			CubicBezier,
			Straight
		}

		public Vector3 pos;

		public Vector3 control1;

		public Vector3 control2;

		public CurveType curveType;

		public bool smooth;

		public GPathPoint(Vector3 pos)
		{
		}

		public GPathPoint(Vector3 pos, Vector3 control)
		{
		}

		public GPathPoint(Vector3 pos, Vector3 control1, Vector3 control2)
		{
		}

		public GPathPoint(Vector3 pos, CurveType curveType)
		{
		}
	}
}
