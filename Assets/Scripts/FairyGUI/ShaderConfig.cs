using UnityEngine;

namespace FairyGUI
{
	public static class ShaderConfig
	{
		public delegate Shader GetFunction(string name);

		public static GetFunction Get;

		public static string imageShader;

		public static string textShader;

		public static string bmFontShader;

		public static string TMPFontShader;

		public static int ID_ClipBox;

		public static int ID_ClipSoftness;

		public static int ID_AlphaTex;

		public static int ID_StencilComp;

		public static int ID_Stencil;

		public static int ID_StencilOp;

		public static int ID_StencilReadMask;

		public static int ID_ColorMask;

		public static int ID_ColorMatrix;

		public static int ID_ColorOffset;

		public static int ID_BlendSrcFactor;

		public static int ID_BlendDstFactor;

		public static int ID_ColorOption;

		public static int ID_Stencil2;

		static ShaderConfig()
		{
		}

		public static Shader GetShader(string name)
		{
			return null;
		}
	}
}
