using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.Audio;

namespace DG.Tweening
{
	public static class DOTweenModuleAudio
	{
		private sealed class _003C_003Ec__DisplayClass0_0
		{
			public AudioSource target;

			internal float _003CDOFade_003Eb__0()
			{
				return 0f;
			}

			internal void _003CDOFade_003Eb__1(float x)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass1_0
		{
			public AudioSource target;

			internal float _003CDOPitch_003Eb__0()
			{
				return 0f;
			}

			internal void _003CDOPitch_003Eb__1(float x)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass2_0
		{
			public AudioMixer target;

			public string floatName;

			internal float _003CDOSetFloat_003Eb__0()
			{
				return 0f;
			}

			internal void _003CDOSetFloat_003Eb__1(float x)
			{
			}
		}

		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			return null;
		}

		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return 0;
		}

		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return 0;
		}

		public static int DOFlip(this AudioMixer target)
		{
			return 0;
		}

		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return 0;
		}

		public static int DOPause(this AudioMixer target)
		{
			return 0;
		}

		public static int DOPlay(this AudioMixer target)
		{
			return 0;
		}

		public static int DOPlayBackwards(this AudioMixer target)
		{
			return 0;
		}

		public static int DOPlayForward(this AudioMixer target)
		{
			return 0;
		}

		public static int DORestart(this AudioMixer target)
		{
			return 0;
		}

		public static int DORewind(this AudioMixer target)
		{
			return 0;
		}

		public static int DOSmoothRewind(this AudioMixer target)
		{
			return 0;
		}

		public static int DOTogglePause(this AudioMixer target)
		{
			return 0;
		}
	}
}
