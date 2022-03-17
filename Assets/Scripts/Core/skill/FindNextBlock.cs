using System.Collections.Generic;

namespace Core.skill
{
	public class FindNextBlock : Skill
	{
		private List<string> _ignoreList;

		public override string logTag => "";

		public FindNextBlock(Knife own)
		{
		}

		public override void OnContactBlock(Block block)
		{
		}

		public override void OnContactWall()
		{
		}

		private void MoveToNextBlock(string blockKey)
		{
		}

		private void FindAndMove2NextTarget()
		{
		}

		public override void UpdateAttr(Dictionary<SkillId, double[]> attrs)
		{
		}
	}
}
