using Core;
using FairyGUI;
using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
	public class DropDiamondEffectHelper
	{
		private GameWorld _world;

		private float dw;

		private float gw;

		private GComponent _parentLayer;

		private int[,] _grids;

		private int col;

		private int row;

		private float startY;

		private int _maxX;

		private int _fixY1;

		private int _fixY2;

		private List<int> _fixYs_left;

		private List<int> _fixYs;

		private int _dropTimes;

		private List<int> _fixYs_right;

		private bool _stopDrop;

		public int _totalCnt;

		public DropDiamondEffectHelper(GameWorld world)
		{
		}

		public void OnStartStage()
		{
		}

		public void DropDiamondChip(Vector2 startPos)
		{
		}

		private void CreateChip(Vector2 startPos)
		{
		}

		public void DoFlyEffect()
		{
		}

		private Vector2 GetEndPos(GComponent com, Vector2 startPos)
		{
			return (Vector2)null;
		}

		private int GetFixY(Vector2 startPos)
		{
			return 0;
		}

		private (int, int) Check(int eX, int eY)
		{
			return ((int, int))null;
		}

		private void SetGridFull(int x, int y)
		{
		}

		private bool IsGridEmpty(int x, int y)
		{
			return false;
		}

		public void Update()
		{
		}
	}
}
