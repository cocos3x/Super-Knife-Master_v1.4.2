using FairyGUI;
using UnityEngine;

namespace XREDEEM
{
	public class RunTextComp : GComponent
	{
		private GTextField _runText;

		private Vector2 _originalPos;

		private float _delayTime;

		private float _speed;

		private bool _startRun;

		public static int fromId_Skin;

		public static int fromId_Redeem;

		private int _fromId;

		public void Init(int fromId)
		{
		}

		private void UpdateText()
		{
		}

		private string GameRedeemText()
		{
			return "";
		}

		protected override void OnUpdate()
		{
		}

		private string GetRandomAccountStr()
		{
			return "";
		}

		private string GetRandomSkinStr()
		{
			return "";
		}
	}
}
