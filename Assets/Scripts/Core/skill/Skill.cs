using System.Collections.Generic;

namespace Core.skill
{
	public abstract class Skill
	{
		public Knife owner;

		public GameWorld world;

		public SkillId skillId;

		public double initCd;

		public double _cd;

		public double _cooldownSpeed;

		public static bool OpenSkillLog;

		public abstract string logTag
		{
			get;
		}

		public Skill(Knife own)
		{
		}

		public abstract void OnContactBlock(Block block);

		public virtual void OnContactWall()
		{
		}

		public virtual void Update(float dt)
		{
		}

		public virtual void Destroy()
		{
		}

		public abstract void UpdateAttr(Dictionary<SkillId, double[]> attrs);

		public void UpdateCooldownSpeed(double[] v)
		{
		}

		public void LogDebug(string str)
		{
		}

		protected float FixScreenScale(float v)
		{
			return 0f;
		}
	}
}
