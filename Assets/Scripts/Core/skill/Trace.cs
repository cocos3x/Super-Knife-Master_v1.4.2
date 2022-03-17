using System.Collections.Generic;
using UnityEngine;

namespace Core.skill
{
	public class Trace : Skill
	{
		private double _traceChance;

		private float _traceRange;

		private int _traceCount;

		private float _curTraceCount;

		private static List<Vector2> normals;

		private List<Rect> _checkRects;

		private static float safeArea;

		public override string logTag => "";

		public Trace(Knife own)
		{
		}

		public override void UpdateAttr(Dictionary<SkillId, double[]> attrs)
		{
		}

		public override void OnContactBlock(Block block)
		{
		}

		public override void Update(float dt)
		{
		}

		private void DoTrace(Block block)
		{
		}

		private void BezierJump(string blockKey)
		{
		}

		private float GetVelocityLength(Vector2 p1, Vector2 p2)
		{
			return 0f;
		}

		private void _003CBezierJump_003Eb__11_0()
		{
		}
	}
}
