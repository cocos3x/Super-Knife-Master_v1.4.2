using UnityEngine;
using UnityEngine.Rendering;

namespace FairyGUI
{
	public class BlendModeUtils
	{
		public class BlendFactor
		{
			public UnityEngine.Rendering.BlendMode srcFactor;

			public UnityEngine.Rendering.BlendMode dstFactor;

			public bool pma;

			public BlendFactor(UnityEngine.Rendering.BlendMode srcFactor, UnityEngine.Rendering.BlendMode dstFactor, bool pma = false)
			{
			}
		}

		public static BlendFactor[] Factors;

		public static void Apply(Material mat, BlendMode blendMode)
		{
		}

		public static void Override(BlendMode blendMode, UnityEngine.Rendering.BlendMode srcFactor, UnityEngine.Rendering.BlendMode dstFactor)
		{
		}
	}
}
