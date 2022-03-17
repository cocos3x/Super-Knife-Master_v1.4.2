using FairyGUI;
using System;

namespace Tool
{
	public class SwallowTouchLayer : GButton
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static EventCallback0 _003C_003E9__3_0;

			internal void _003Cget_instance_003Eb__3_0()
			{
			}
		}

		private static SwallowTouchLayer s_instance;

		private static float _duration;

		public static SwallowTouchLayer instance => null;

		protected override void OnUpdate()
		{
		}

		public void ForbidTouch(float time)
		{
		}

		public void RemoveSwallow()
		{
		}
	}
}
