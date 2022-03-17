using System.Numerics;
using UnityEngine;

namespace Core
{
	public class BlockDiamond : Block
	{
		public override void OnEnterWorld(GameWorld world, string key, Vector2 pos, BigInteger oldHp)
		{
		}

		protected override void OnBlockDead()
		{
		}

		protected override void ShowHitEffect(bool isTap)
		{
		}
	}
}
