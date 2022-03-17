using Core;
using FairyGUI;
using System;
using UnityEngine;

namespace Ui
{
	public class MainScene : MonoBehaviour
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Action _003C_003E9__18_0;

			internal void _003CCheckOfflineReward_003Eb__18_0()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass22_0
		{
			public GObject finger;

			public Block targetBlock;

			internal void _003CCheckSkinBlockGuide_003Eg__Callback_007C1()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass24_0
		{
			public Block targetBlock;

			public MainScene _003C_003E4__this;

			internal void _003CCheckBossGuide_003Eg__Callback_007C0()
			{
			}
		}

		[SerializeField]
		private GameWorld _world;

		public GComponent view;

		public MainTop top;

		public MainBottom bottom;

		public GComponent topEffectLayer;

		public GComponent bottomEffectLayer;

		public BuffTipsBtn buffTipsBtn;

		public KnifeTipsBtn knifeTipsBtn;

		public GObject bossGuideTips;

		private GComponent bossGuideFinger;

		private static MainScene _003Cinstance_003Ek__BackingField;

		public GameWorld world => null;

		public static MainScene instance
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void CheckOfflineReward()
		{
		}

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}

		public void CheckGameGuide()
		{
		}

		public void CheckSkinBlockGuide()
		{
		}

		public GObject CreateGuideFinger(GComponent parent, Vector2 pos, string url = "ui://Main/手指")
		{
			return null;
		}

		public void CheckBossGuide()
		{
		}

		public void RefreshBossTips(bool show)
		{
		}

		private void _003CCheckSkinBlockGuide_003Eb__22_0()
		{
		}
	}
}
