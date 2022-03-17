using System.Numerics;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Core
{
	public class BlockBoss : Block
	{
		private float _maxBossScale;

		private float _minBossScale;

		private float _bossInitR;

		private int _dropTime;

		private long _curHpProgress;

		private long _lastHpProgress;

		private double curHpPercent => 0.0;

		public override void OnEnterWorld(GameWorld world, string key, Vector2 pos, BigInteger oldHp)
		{
		}

		private void CheckBossDropDiamond(Vector2 pos)
		{
		}

		public void UpdateBossSize()
		{
		}

		public override void OnKnifeHit(BigInteger attack, [Optional] Vector2 hitPos, bool isTap = false)
		{
		}

		protected override void ShowHitEffect(bool isTap)
		{
		}

		private void _003CShowHitEffect_003Eb__12_0()
		{
		}
	}
}
