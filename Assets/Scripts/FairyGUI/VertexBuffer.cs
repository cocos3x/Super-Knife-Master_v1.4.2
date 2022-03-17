using System.Collections.Generic;
using UnityEngine;

namespace FairyGUI
{
	public sealed class VertexBuffer
	{
		public Rect contentRect;

		public Rect uvRect;

		public Color32 vertexColor;

		public Vector2 textureSize;

		public readonly List<Vector3> vertices;

		public readonly List<Color32> colors;

		public readonly List<Vector2> uvs;

		public readonly List<Vector2> uvs2;

		public readonly List<int> triangles;

		public static Vector2[] NormalizedUV;

		public static Vector2[] NormalizedPosition;

		internal bool _alphaInVertexColor;

		internal bool _isArbitraryQuad;

		private static Stack<VertexBuffer> _pool;

		private static List<Vector4> helperV4List;

		public int currentVertCount => 0;

		public static VertexBuffer Begin()
		{
			return null;
		}

		public static VertexBuffer Begin(VertexBuffer source)
		{
			return null;
		}

		private VertexBuffer()
		{
		}

		public void End()
		{
		}

		public void Clear()
		{
		}

		public void AddVert(Vector3 position)
		{
		}

		public void AddVert(Vector3 position, Color32 color)
		{
		}

		public void AddVert(Vector3 position, Color32 color, Vector2 uv)
		{
		}

		public void AddQuad(Rect vertRect)
		{
		}

		public void AddQuad(Rect vertRect, Color32 color)
		{
		}

		public void AddQuad(Rect vertRect, Color32 color, Rect uvRect)
		{
		}

		internal List<Vector4> FixUVForArbitraryQuad()
		{
			return null;
		}

		public void RepeatColors(Color32[] value, int startIndex, int count)
		{
		}

		public void AddTriangle(int idx0, int idx1, int idx2)
		{
		}

		public void AddTriangles(int[] idxList, int startVertexIndex = 0)
		{
		}

		public void AddTriangles(int startVertexIndex = 0)
		{
		}

		public Vector3 GetPosition(int index)
		{
			return (Vector3)null;
		}

		public Vector2 GetUVAtPosition(Vector2 position, bool usePercent)
		{
			return (Vector2)null;
		}

		public void Append(VertexBuffer vb)
		{
		}

		public void Insert(VertexBuffer vb)
		{
		}
	}
}
