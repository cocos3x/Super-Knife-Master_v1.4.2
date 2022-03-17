using System.Collections.Generic;
using UnityEngine;

namespace Core.skill
{
	public class Laser : Skill
	{
		private sealed class _003C_003Ec__DisplayClass13_0
		{
			public GEffectNode baseNode;

			internal void _003CShowLaserBase_003Eb__0()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass14_0
		{
			public GEffectNode laserNode;

			internal void _003CShowLaserLine_003Eb__0()
			{
			}
		}

		private double _laserChance;

		private float _laserRange;

		private int _laserCount;

		private float _laserLifeTime;

		private List<string> _hitBlocksList;

		private RaycastHit2D[] _raycastHits;

		public override string logTag => "";

		public Laser(Knife own)
		{
		}

		public override void UpdateAttr(Dictionary<SkillId, double[]> attrs)
		{
		}

		public override void OnContactBlock(Block block)
		{
		}

		private void MakeLaserDamage(Block block)
		{
		}

		private void HitBlock(Vector2 worldPos, float angle, float radius)
		{
		}

		private void ShowLaserBase(Vector2 worldPos)
		{
		}

		private void ShowLaserLine(Vector2 worldPos, float angle, float radius)
		{
		}
	}
}
