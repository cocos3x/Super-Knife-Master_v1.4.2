using DG.Tweening;
using FairyGUI;
using FairyGUI.Utils;
using System;
using System.Collections.Generic;

namespace Dialogs
{
	public class MultipleListNode : GComponent
	{
		public delegate void Callback();

		private class Items
		{
			public GComponent node;

			public double multiple;

			public int multipleIndex;
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static TweenCallback _003C_003E9__23_0;

			public static TweenCallback _003C_003E9__23_1;

			public static TweenCallback _003C_003E9__23_2;

			internal void _003CStep_003Eb__23_0()
			{
			}

			internal void _003CStep_003Eb__23_1()
			{
			}

			internal void _003CStep_003Eb__23_2()
			{
			}
		}

		private double[] _multiples;

		private string[] _multipleStrList;

		private List<Items> _itemList;

		private GComponent _container;

		private float _spaceX;

		private int _currentId;

		private int _velocityStep;

		private float _accleTime;

		private float _accleDuration;

		private float _velocity;

		private float _velocityStart;

		private float _velocityDelta;

		private bool _spinning;

		private int _targetSpinId;

		private bool _stopping;

		private float _totalWidth;

		private float _itemWidth;

		private Callback _call;

		public void InitCallback(Callback call)
		{
		}

		public void SetMultipleList(string[] args)
		{
		}

		public override void ConstructFromXML(XML xml)
		{
		}

		private void Step(float dt)
		{
		}

		protected override void OnUpdate()
		{
		}

		private bool CheckOutOfViewItem()
		{
			return false;
		}

		private void MoveRightToLeft()
		{
		}

		private void SetItemMultipleIndex(Items item, int index)
		{
		}

		private bool IsItemOutOfViewRight(int index)
		{
			return false;
		}

		public double GetMultiple(int index)
		{
			return 0.0;
		}

		private int NormalMultipleIndex(int index)
		{
			return 0;
		}

		private GLabel CreateGrid()
		{
			return null;
		}

		private void AddMultipleItem()
		{
		}

		private void RefreshMultiple()
		{
		}

		public void StartSpin(int targetIndex, float delayTime)
		{
		}

		public void StopSpin()
		{
		}

		private void _003CStep_003Eb__23_3()
		{
		}

		private void _003CStartSpin_003Eb__34_0()
		{
		}
	}
}
