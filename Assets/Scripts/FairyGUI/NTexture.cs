using System;
using System.Collections.Generic;
using UnityEngine;

namespace FairyGUI
{
	public class NTexture
	{
		public Rect uvRect;

		public bool rotated;

		public int refCount;

		public float lastActive;

		public DestroyMethod destroyMethod;

		private Texture _nativeTexture;

		private Texture _alphaTexture;

		private Rect _region;

		private Vector2 _offset;

		private Vector2 _originalSize;

		private NTexture _root;

		private Dictionary<string, MaterialManager> _materialManagers;

		private static NTexture _empty;

		public static NTexture Empty => null;

		public int width => 0;

		public int height => 0;

		public Vector2 offset
		{
			get
			{
				return (Vector2)null;
			}
			set
			{
			}
		}

		public Vector2 originalSize
		{
			get
			{
				return (Vector2)null;
			}
			set
			{
			}
		}

		public NTexture root => null;

		public bool disposed => false;

		public Texture nativeTexture => null;

		public Texture alphaTexture => null;

		public static event Action<Texture> CustomDestroyMethod
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<NTexture> onSizeChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<NTexture> onRelease
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static Texture2D CreateEmptyTexture()
		{
			return null;
		}

		public static void DisposeEmpty()
		{
		}

		public NTexture(Texture texture)
		{
		}

		public NTexture(Texture texture, Texture alphaTexture, float xScale, float yScale)
		{
		}

		public NTexture(Texture texture, Rect region)
		{
		}

		public NTexture(NTexture root, Rect region, bool rotated)
		{
		}

		public NTexture(NTexture root, Rect region, bool rotated, Vector2 originalSize, Vector2 offset)
		{
		}

		public NTexture(Sprite sprite)
		{
		}

		public Rect GetDrawRect(Rect drawRect)
		{
			return (Rect)null;
		}

		public void GetUV(Vector2[] uv)
		{
		}

		public MaterialManager GetMaterialManager(string shaderName)
		{
			return null;
		}

		public void Unload()
		{
		}

		public void Unload(bool destroyMaterials)
		{
		}

		public void Reload(Texture nativeTexture, Texture alphaTexture)
		{
		}

		private void DestroyTexture()
		{
		}

		private void RefreshMaterials()
		{
		}

		private void DestroyMaterials()
		{
		}

		public void AddRef()
		{
		}

		public void ReleaseRef()
		{
		}

		public void Dispose()
		{
		}
	}
}
