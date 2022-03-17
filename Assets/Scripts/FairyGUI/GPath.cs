using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace FairyGUI
{
	public class GPath
	{
		protected struct Segment
		{
			public GPathPoint.CurveType type;

			public float length;

			public int ptStart;

			public int ptCount;
		}

		protected List<Segment> _segments;

		protected List<Vector3> _points;

		protected float _fullLength;

		private static List<GPathPoint> helperList;

		private static List<Vector3> splinePoints;

		public float length => 0f;

		public int segmentCount => 0;

		public void Create(GPathPoint pt1, GPathPoint pt2)
		{
		}

		public void Create(GPathPoint pt1, GPathPoint pt2, GPathPoint pt3)
		{
		}

		public void Create(GPathPoint pt1, GPathPoint pt2, GPathPoint pt3, GPathPoint pt4)
		{
		}

		public void Create(IEnumerable<GPathPoint> points)
		{
		}

		private void CreateSplineSegment()
		{
		}

		public void Clear()
		{
		}

		public Vector3 GetPointAt(float t)
		{
			return (Vector3)null;
		}

		public float GetSegmentLength(int segmentIndex)
		{
			return 0f;
		}

		public void GetPointsInSegment(int segmentIndex, float t0, float t1, List<Vector3> points, [Optional] List<float> ts, float pointDensity = 0.1f)
		{
		}

		public void GetAllPoints(List<Vector3> points, float pointDensity = 0.1f)
		{
		}

		private Vector3 onCRSplineCurve(int ptStart, int ptCount, float t)
		{
			return (Vector3)null;
		}

		private Vector3 onBezierCurve(int ptStart, int ptCount, float t)
		{
			return (Vector3)null;
		}
	}
}
