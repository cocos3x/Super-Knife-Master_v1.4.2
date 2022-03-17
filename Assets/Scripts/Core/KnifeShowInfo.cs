using ExcelConfig;
using Presenter;
using System.Numerics;

namespace Core
{
	public class KnifeShowInfo
	{
		public int knifeId;

		public KnifeType type;

		public KnifeLocalConfig config;

		public int lv;

		public string lvStr;

		public bool isUnlock;

		public string unlockLvStr;

		public BigInteger upgradePrice;

		public BigInteger attack;

		public string showAtkStr;

		public BigInteger realAttack;

		public BigInteger upgradePerformance;

		public int unlockLevel;

		public BigInteger baseAttack;

		public double attackUpRatio;

		public BigInteger basePrice;

		public double priceUpRatio;

		public bool isTap => false;

		public bool isNormalWeapon => false;

		public bool isLegendaryWeapon => false;

		public bool isSplitWeapon => false;

		public bool isFireBall => false;
	}
}
