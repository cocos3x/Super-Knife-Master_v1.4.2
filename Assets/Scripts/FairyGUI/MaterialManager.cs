using System;
using System.Collections.Generic;
using UnityEngine;

namespace FairyGUI
{
	public class MaterialManager
	{
		private class MaterialRef
		{
			public Material material;

			public int frame;

			public BlendMode blendMode;

			public uint group;
		}

		public bool firstMaterialInFrame;

		private NTexture _texture;

		private Shader _shader;

		private List<string> _addKeywords;

		private Dictionary<int, List<MaterialRef>> _materials;

		private bool _combineTexture;

		private const int internalKeywordsCount = 6;

		private static string[] internalKeywords;

		public event Action<Material> onCreateNewMaterial
		{
			add
			{
			}
			remove
			{
			}
		}

		internal MaterialManager(NTexture texture, Shader shader)
		{
		}

		public int GetFlagsByKeywords(IList<string> keywords)
		{
			return 0;
		}

		public Material GetMaterial(int flags, BlendMode blendMode, uint group)
		{
			return null;
		}

		private Material CreateMaterial(int flags)
		{
			return null;
		}

		public void DestroyMaterials()
		{
		}

		public void RefreshMaterials()
		{
		}
	}
}
