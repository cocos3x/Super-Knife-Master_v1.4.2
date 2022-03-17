using System.Numerics;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Core
{
	public class BlockNormal : Block
	{
		private BlockColorHelper.ColorConfig _colorConfig;

		public override void OnEnterWorld(GameWorld world, string key, Vector2 pos, BigInteger oldHp)
		{
		}

		public override void OnKnifeHit(BigInteger attack, [Optional] Vector2 hitPos, bool isTap = false)
		{
		}

		protected override void OnBlockDead()
		{
		}

		private void SetNormalState()
		{
		}

		private void SetHitState()
		{
		}

		protected override void ShowHitEffect(bool isTap)
		{
		}

		private void UpdateColor()
		{
		}

		private void _003CShowHitEffect_003Eb__6_0()
		{
		}
	}
}
