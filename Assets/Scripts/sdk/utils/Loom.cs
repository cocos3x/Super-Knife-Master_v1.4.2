using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace sdk.utils
{
	public class Loom : MonoBehaviour
	{
		private struct DelayedQueueItem
		{
			public float Time;

			public Action Action;
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Func<DelayedQueueItem, bool> _003C_003E9__19_0;

			internal bool _003CUpdate_003Eb__19_0(DelayedQueueItem d)
			{
				return false;
			}
		}

		private const int MaxThreads = 8;

		private static int _numThreads;

		private static Loom _current;

		private int _count;

		private static bool _initialized;

		private readonly List<Action> _actions;

		private readonly List<DelayedQueueItem> _delayed;

		private readonly List<DelayedQueueItem> _currentDelayed;

		private readonly List<Action> _currentActions;

		public static Loom Current => null;

		private void Awake()
		{
		}

		private static void Initialize()
		{
		}

		public static void QueueOnMainThread(Action action)
		{
		}

		private static void QueueOnMainThread(Action action, float time)
		{
		}

		public static Thread RunAsync(Action a)
		{
			return null;
		}

		public static void RunAction(object action)
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}
	}
}
