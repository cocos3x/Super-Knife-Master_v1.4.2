using System.Collections.Generic;

namespace Core.skill
{
	public class SkillMgr
	{
		private Dictionary<SkillId, Skill> _skills;

		private Dictionary<SkillId, double[]> skillAttrs;

		private Knife _owner;

		public SkillMgr(Knife owner)
		{
		}

		public void Destroy()
		{
		}

		public void Update(float dt)
		{
		}

		public void UpdateSkillList(KnifeShowInfo info)
		{
		}

		public void AddSkill(SkillId skillId)
		{
		}

		public void OnContactBlock(Block block)
		{
		}

		public void OnContactWall()
		{
		}
	}
}
