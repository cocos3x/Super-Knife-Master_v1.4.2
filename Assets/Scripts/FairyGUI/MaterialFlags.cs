using System;

namespace FairyGUI
{
	[Flags]
	public enum MaterialFlags
	{
		Clipped = 0x1,
		SoftClipped = 0x2,
		StencilTest = 0x4,
		AlphaMask = 0x8,
		Grayed = 0x10,
		ColorFilter = 0x20
	}
}
