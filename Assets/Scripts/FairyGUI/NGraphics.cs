using System;
using System.Collections.Generic;
using UnityEngine;

namespace FairyGUI
{
	public class NGraphics : IMeshFactory
	{
		public class VertexMatrix
		{
			public Vector3 cameraPos;

			public Matrix4x4 matrix;
		}

		private class StencilEraser
		{
			public GameObject gameObject;

			public MeshFilter meshFilter;

			public MeshRenderer meshRenderer;

			public bool enabled
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public StencilEraser(Transform parent)
			{
			}
		}

		private GameObject _003CgameObject_003Ek__BackingField;

		private MeshFilter _003CmeshFilter_003Ek__BackingField;

		private MeshRenderer _003CmeshRenderer_003Ek__BackingField;

		private Mesh _003Cmesh_003Ek__BackingField;

		public BlendMode blendMode;

		public bool dontClip;

		private NTexture _texture;

		private string _shader;

		private Material _material;

		private int _customMatarial;

		private MaterialManager _manager;

		private string[] _shaderKeywords;

		private int _materialFlags;

		private IMeshFactory _meshFactory;

		private float _alpha;

		private Color _color;

		private bool _meshDirty;

		private Rect _contentRect;

		private FlipType _flip;

		private VertexMatrix _vertexMatrix;

		private bool hasAlphaBackup;

		private List<byte> _alphaBackup;

		internal int _maskFlag;

		private StencilEraser _stencilEraser;

		private MaterialPropertyBlock _propertyBlock;

		private bool _blockUpdated;

		public GameObject gameObject
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public MeshFilter meshFilter
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public MeshRenderer meshRenderer
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public Mesh mesh
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public IMeshFactory meshFactory
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Rect contentRect
		{
			get
			{
				return (Rect)null;
			}
			set
			{
			}
		}

		public FlipType flip
		{
			get
			{
				//IL_0003: Expected I4, but got O
				return (FlipType)null;
			}
			set
			{
			}
		}

		public NTexture texture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string shader
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public Material material
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string[] materialKeywords
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int sortingOrder
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Color color
		{
			get
			{
				return (Color)null;
			}
			set
			{
			}
		}

		public VertexMatrix vertexMatrix
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public MaterialPropertyBlock materialPropertyBlock => null;

		public event Action meshModifier
		{
			add
			{
			}
			remove
			{
			}
		}

		public NGraphics(GameObject gameObject)
		{
		}

		public T GetMeshFactory<T>() where T : IMeshFactory, new()
		{
			return (T)null;
		}

		public void SetShaderAndTexture(string shader, NTexture texture)
		{
		}

		public void SetMaterial(Material material)
		{
		}

		public void ToggleKeyword(string keyword, bool enabled)
		{
		}

		private void UpdateManager()
		{
		}

		private void UpdateMaterialFlags()
		{
		}

		internal void _SetStencilEraserOrder(int value)
		{
		}

		public void Tint()
		{
		}

		private void ChangeAlpha(float value)
		{
		}

		public void SetMeshDirty()
		{
		}

		public bool UpdateMesh()
		{
			return false;
		}

		public void Dispose()
		{
		}

		public void Update(UpdateContext context, float alpha, bool grayed)
		{
		}

		internal void _PreUpdateMask(UpdateContext context, uint maskId)
		{
		}

		private void UpdateMeshNow()
		{
		}

		public void OnPopulateMesh(VertexBuffer vb)
		{
		}
	}
}
