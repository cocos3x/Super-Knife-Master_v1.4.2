using System;
using UnityEngine;

namespace Master
{
	public class SCameraAdjust : MonoBehaviour
	{
		public class Listener : SEventDispatch<int>
		{
			internal bool isFinishScale;

			public void OnFieldOfViewUpdate(object objKey, Action callback)
			{
			}
		}

		private float _rawFieldOfView;

		private static SCameraAdjust _sInstance;

		[SerializeField]
		private float _maxScale;

		private readonly Listener _003Clistener_003Ek__BackingField;

		private float _003CfixScale_003Ek__BackingField;

		public static SCameraAdjust instance => null;

		public Listener listener => null;

		public float fixScale
		{
			get
			{
				return 0f;
			}
			private set
			{
			}
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}
	}
}
