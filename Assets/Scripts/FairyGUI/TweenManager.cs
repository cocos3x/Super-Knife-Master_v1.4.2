using System.Collections.Generic;
using UnityEngine;

namespace FairyGUI
{
	internal static class TweenManager
	{
		private class TweenEngine : MonoBehaviour
		{
			private void Update()
			{
			}
		}

		private static GTweener[] _activeTweens;

		private static List<GTweener> _tweenerPool;

		private static int _totalActiveTweens;

		private static bool _inited;

		internal static GTweener CreateTween()
		{
			return null;
		}

		internal static bool IsTweening(object target, TweenPropType propType)
		{
			return false;
		}

		internal static bool KillTweens(object target, TweenPropType propType, bool completed)
		{
			return false;
		}

		internal static GTweener GetTween(object target, TweenPropType propType)
		{
			return null;
		}

		internal static void Update()
		{
		}

		internal static void Clean()
		{
		}

		private static void Init()
		{
		}
	}
}
