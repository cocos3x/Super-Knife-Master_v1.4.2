using System;
using System.Runtime.InteropServices;

namespace FairyGUI
{
	public static class EaseManager
	{
		private static class Bounce
		{
			public static float EaseIn(float time, float duration)
			{
				return 0f;
			}

			public static float EaseOut(float time, float duration)
			{
				return 0f;
			}

			public static float EaseInOut(float time, float duration)
			{
				return 0f;
			}
		}

		private const float _PiOver2 = (float)Math.PI / 2f;

		private const float _TwoPi = (float)Math.PI * 2f;

		public static float Evaluate(EaseType easeType, float time, float duration, float overshootOrAmplitude = 1.70158f, float period = 0f, [Optional] CustomEase customEase)
		{
			return 0f;
		}
	}
}
