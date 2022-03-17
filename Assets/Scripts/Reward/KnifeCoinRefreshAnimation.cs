using FairyGUI;
using Master;
using System;
using System.Collections.Generic;
using System.Numerics;
using Ui;
using UnityEngine;

namespace Reward
{
	public class KnifeCoinRefreshAnimation
	{
		public enum AnimType
		{
			KnifeCoin,
			CollectKnifeCoin
		}

		public class AnimationEntry
		{
			public AnimType type;

			private double passTime;

			private long targetValue;

			private long startValue;

			private long deltaValue;

			private bool running;

			private double duration;

			internal long curValue;

			internal bool isValueChange;

			public int flyCount;

			public string iconUrl;

			public GObject endIcon;

			public GTextField textField;

			public bool isBigInt;

			private BigInteger deltaBigIntValue;

			internal BigInteger curBigIntValue;

			internal BigInteger startBigIntValue;

			internal BigInteger targetBigIntValue;

			public void RefreshValue(BigInteger newValue)
			{
			}

			public void RefreshValue(long newValue)
			{
			}

			public void Update(float dt)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass11_0
		{
			public KnifeCoinRefreshAnimation _003C_003E4__this;

			public AnimType type;

			public Vector2 startPos;
		}

		private sealed class _003C_003Ec__DisplayClass11_1
		{
			public float delay;

			public _003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals1;

			internal void _003CShowFlyEffect_003Eb__1()
			{
			}
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Action _003C_003E9__11_0;

			internal void _003CShowFlyEffect_003Eb__11_0()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass12_0
		{
			public GComponent node;

			public KnifeCoinRefreshAnimation _003C_003E4__this;

			public AnimType type;

			internal void _003CCreateFlyIcon_003Eb__0()
			{
			}

			internal void _003CCreateFlyIcon_003Eb__1()
			{
			}
		}

		private Dictionary<AnimType, AnimationEntry> _anims;

		private readonly STimer _timer;

		public KnifeCoinRefreshAnimation(MainScene scene)
		{
		}

		private void AddAnimType(AnimType type, GTextField textField, GObject endIcon, string iconUrl, bool isBigInt = false)
		{
		}

		private void OnGameValueChanged(AnimType type)
		{
		}

		private long GetTargetValue(AnimType type)
		{
			return 0L;
		}

		private BigInteger GetTargetValue_BigInt(AnimType type)
		{
			return (BigInteger)null;
		}

		private void SyncCount(AnimType type)
		{
		}

		private void OnIconFlyFinish(AnimType type)
		{
		}

		private void SetText(AnimType type)
		{
		}

		private void ShowFlyEffect(AnimType type, int flyCount = 20)
		{
		}

		private void CreateFlyIcon(AnimType type, float delay, Vector2 startPos)
		{
		}

		private void Update()
		{
		}

		private void _003C_002Ector_003Eb__3_0()
		{
		}

		private void _003C_002Ector_003Eb__3_1()
		{
		}

		private void _003C_002Ector_003Eb__3_2()
		{
		}

		private void _003C_002Ector_003Eb__3_3()
		{
		}

		private void _003C_002Ector_003Eb__3_4()
		{
		}
	}
}
