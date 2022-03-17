using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FairyGUI
{
	public class Timers
	{
		public static int repeat;

		public static float time;

		public static bool catchCallbackExceptions;

		private Dictionary<TimerCallback, Anymous_T> _items;

		private Dictionary<TimerCallback, Anymous_T> _toAdd;

		private List<Anymous_T> _toRemove;

		private List<Anymous_T> _pool;

		private TimersEngine _engine;

		private GameObject gameObject;

		private static Timers _inst;

		public static Timers inst => null;

		public void Add(float interval, int repeat, TimerCallback callback)
		{
		}

		public void Add(float interval, int repeat, TimerCallback callback, object callbackParam)
		{
		}

		public void CallLater(TimerCallback callback)
		{
		}

		public void CallLater(TimerCallback callback, object callbackParam)
		{
		}

		public void AddUpdate(TimerCallback callback)
		{
		}

		public void AddUpdate(TimerCallback callback, object callbackParam)
		{
		}

		public void StartCoroutine(IEnumerator routine)
		{
		}

		public bool Exists(TimerCallback callback)
		{
			return false;
		}

		public void Remove(TimerCallback callback)
		{
		}

		private Anymous_T GetFromPool()
		{
			return null;
		}

		private void ReturnToPool(Anymous_T t)
		{
		}

		public void Update()
		{
		}
	}
}
