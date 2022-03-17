using FairyGUI;
using UnityEngine;

namespace DefaultNamespace
{
	public class DropDiamond : GComponent
	{
		public static string iconUrl;

		private float _g;

		private float _t;

		private float _runTime;

		private float _vX;

		private float _vY;

		private Vector2 _startP;

		private Vector2 _endPos;

		private bool _stopFly;

		private bool _flyToEndPos;

		private Vector2 _flyEndPos;

		private float _delayTime;

		private float _initFlyTime;

		private float _curFlyTime;

		public bool _isDead;

		private Vector2 _flyStartPos;

		public void Init(Vector2 startP, Vector2 endP)
		{
		}

		protected override void OnUpdate()
		{
		}

		public void FlyToEndPos(Vector2 endP)
		{
		}
	}
}
