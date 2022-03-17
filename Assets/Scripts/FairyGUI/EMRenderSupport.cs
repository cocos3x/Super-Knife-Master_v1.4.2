using System.Collections.Generic;

namespace FairyGUI
{
	public class EMRenderSupport
	{
		public static bool orderChanged;

		private static UpdateContext _updateContext;

		private static List<EMRenderTarget> _targets;

		private static bool _003CpackageListReady_003Ek__BackingField;

		public static bool packageListReady
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		public static bool hasTarget => false;

		public static void Add(EMRenderTarget value)
		{
		}

		public static void Remove(EMRenderTarget value)
		{
		}

		public static void Update()
		{
		}

		public static void Reload()
		{
		}

		private static int CompareDepth(EMRenderTarget c1, EMRenderTarget c2)
		{
			return 0;
		}
	}
}
