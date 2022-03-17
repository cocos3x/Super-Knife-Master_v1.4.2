using System.Collections.Generic;
using UnityEngine;

namespace Core
{
	public class BlockPositionHelper
	{
		private float _radius;

		private float _minInterval;

		private float topY;

		private float bottomY;

		private float midX;

		private float midY;

		private int targetCnt;

		private List<Vector2> _posList;

		private static BlockPositionHelper _instance;

		public static BlockPositionHelper instance => null;

		public List<Vector2> CreatePosList(int count)
		{
			return null;
		}

		private bool IsValidPosition(float rX, float rY)
		{
			return false;
		}

		public void GeneratePosConfigJson()
		{
		}

		private void SavePosConfigJson(int count, List<List<Vector2>> l)
		{
		}
	}
}
