using ExcelConfig;
using Master;

namespace Presenter
{
	public class CalculatePresenter : Presenter<CalculatePresenter>
	{
		public class MultipleInfo
		{
			public double mul;

			public int mulIndex;

			public string[] multipleStrList;
		}

		public static string[] DefaultMulStr;

		public double diamond => 0.0;

		public long coupon => 0L;

		public double diamondRatio => 0.0;

		public double couponRatio => 0.0;

		public long diamondTarget => 0L;

		public long couponTarget => 0L;

		public double couponRewardCoef => 0.0;

		internal override void OnInit()
		{
		}

		public MultipleInfo GetMultipleReward()
		{
			return null;
		}

		private BaseRewardConfigItem GetBaseRewardConfig(int lv)
		{
			return null;
		}

		public double GetDiamondRewardCoef()
		{
			return 0.0;
		}

		public long CalcNormalBlockCoupon()
		{
			return 0L;
		}

		public long CalcDiamondBlockReward(int lv)
		{
			return 0L;
		}

		public long GetNormalStageRewardDiamond(int lv)
		{
			return 0L;
		}

		public long GetBossStageRewardDiamond(int lv)
		{
			return 0L;
		}
	}
}
