using System.Collections.Generic;

namespace Core.skill
{
	public class Bomb : Skill
	{
		private sealed class _003C_003Ec__DisplayClass8_0
		{
			public Block block;

			public Bomb _003C_003E4__this;

			internal void _003CMakeBombDamage_003Eb__0()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass10_0
		{
			public Block block;

			internal void _003CShowBombEffect_003Eb__0()
			{
			}
		}

		private double _bombChance;

		private float _bombRange;

		private float _bombLinkChance;

		private List<string> _ignoreBlocks;

		public override string logTag => "";

		public Bomb(Knife own)
		{
		}

		public override void OnContactBlock(Block block)
		{
		}

		private void MakeBombDamage(Block block, float delay)
		{
		}

		private void CheckLinkBomb(Block block)
		{
		}

		private void ShowBombEffect(Block block, float radius)
		{
		}

		public override void UpdateAttr(Dictionary<SkillId, double[]> attrs)
		{
		}
	}
}
