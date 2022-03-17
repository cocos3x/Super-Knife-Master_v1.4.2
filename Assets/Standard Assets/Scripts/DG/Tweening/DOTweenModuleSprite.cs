using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace DG.Tweening
{
	public static class DOTweenModuleSprite
	{
		private sealed class _003C_003Ec__DisplayClass0_0
		{
			public SpriteRenderer target;

			internal Color _003CDOColor_003Eb__0()
			{
				return (Color)null;
			}

			internal void _003CDOColor_003Eb__1(Color x)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass1_0
		{
			public SpriteRenderer target;

			internal Color _003CDOFade_003Eb__0()
			{
				return (Color)null;
			}

			internal void _003CDOFade_003Eb__1(Color x)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass3_0
		{
			public Color to;

			public SpriteRenderer target;

			internal Color _003CDOBlendableColor_003Eb__0()
			{
				return (Color)null;
			}

			internal void _003CDOBlendableColor_003Eb__1(Color x)
			{
			}
		}

		public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}

		public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			return null;
		}

		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			return null;
		}

		public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}
	}
}
