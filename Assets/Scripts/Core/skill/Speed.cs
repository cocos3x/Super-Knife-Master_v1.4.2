using System.Collections.Generic;

namespace Core.skill
{
	public class Speed : Skill
	{
		public static float initSpeed;

		private double _speedMul;

		public override string logTag => "";

		public Speed(Knife own)
		{
		}

		public override void OnContactBlock(Block block)
		{
		}

		public override void UpdateAttr(Dictionary<SkillId, double[]> attrs)
		{
		}

		private void UpdateSpeed()
		{
		}

		public override void Destroy()
		{
		}
	}
}
