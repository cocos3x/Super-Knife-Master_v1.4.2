using System.Collections.Generic;
using UnityEngine;

namespace FairyGUI
{
	public class GObjectPool
	{
		public delegate void InitCallbackDelegate(GObject obj);

		public InitCallbackDelegate initCallback;

		private Dictionary<string, Queue<GObject>> _pool;

		private Transform _manager;

		public int count => 0;

		public GObjectPool(Transform manager)
		{
		}

		public void Clear()
		{
		}

		public GObject GetObject(string url)
		{
			return null;
		}

		public void ReturnObject(GObject obj)
		{
		}
	}
}
