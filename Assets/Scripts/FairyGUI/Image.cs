using UnityEngine;

namespace FairyGUI
{
	public class Image : DisplayObject, IMeshFactory
	{
		protected Rect? _scale9Grid;

		protected bool _scaleByTile;

		protected Vector2 _textureScale;

		protected int _tileGridIndice;

		protected FillMesh _fillMesh;

		private static int[] TRIANGLES_9_GRID;

		private static int[] gridTileIndice;

		private static float[] gridX;

		private static float[] gridY;

		private static float[] gridTexX;

		private static float[] gridTexY;

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

		public Vector2 textureScale
		{
			get
			{
				return (Vector2)null;
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

		public FillMethod fillMethod
		{
			get
			{
				//IL_0003: Expected I4, but got O
				return (FillMethod)null;
			}
			set
			{
			}
		}

		public int fillOrigin
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool fillClockwise
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float fillAmount
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Rect? scale9Grid
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool scaleByTile
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int tileGridIndice
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Image()
		{
		}

		public Image(NTexture texture)
		{
		}

		public void SetNativeSize()
		{
		}

		protected virtual void UpdateTexture(NTexture value)
		{
		}

		public void OnPopulateMesh(VertexBuffer vb)
		{
		}

		public void SliceFill(VertexBuffer vb)
		{
		}

		private void TileFill(VertexBuffer vb, Rect contentRect, Rect uvRect, float sourceW, float sourceH)
		{
		}
	}
}
