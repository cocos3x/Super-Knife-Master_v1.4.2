using System;
using System.Collections.Generic;
using UnityEngine;

namespace FairyGUI
{
	public class GoWrapper : DisplayObject
	{
		protected struct RendererInfo
		{
			public Renderer renderer;

			public Material[] materials;

			public int sortingOrder;
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Comparison<RendererInfo> _003C_003E9__19_0;

			internal int _003CCacheRenderers_003Eb__19_0(RendererInfo c1, RendererInfo c2)
			{
				return 0;
			}
		}

		public bool supportStencil;

		protected GameObject _wrapTarget;

		protected List<RendererInfo> _renderers;

		protected Dictionary<Material, Material> _materialsBackup;

		protected Canvas _canvas;

		protected bool _cloneMaterial;

		protected bool _shouldCloneMaterial;

		protected static List<Transform> helperTransformList;

		private List<Material> helperMaterials;

		public GameObject wrapTarget
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override int renderingOrder
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public event Action<UpdateContext> onUpdate
		{
			add
			{
			}
			remove
			{
			}
		}

		public GoWrapper()
		{
		}

		public GoWrapper(GameObject go)
		{
		}

		public void setWrapTarget(GameObject target, bool cloneMaterial)
		{
		}

		public void SetWrapTarget(GameObject target, bool cloneMaterial)
		{
		}

		public void CacheRenderers()
		{
		}

		private void CloneMaterials()
		{
		}

		private void RecoverMaterials()
		{
		}

		protected override bool SetLayer(int value, bool fromParent)
		{
			return false;
		}

		protected void SetGoLayers(int layer)
		{
		}

		public override void Update(UpdateContext context)
		{
		}

		protected virtual void ApplyClipping(UpdateContext context)
		{
		}

		public override void Dispose()
		{
		}
	}
}
