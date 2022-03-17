using System.Collections.Generic;
using UnityEngine;

namespace Tool
{
	public abstract class SObjectPool<T, TObjType> where T : class, new()
	{
		private static T _instance;

		private readonly Dictionary<int, List<TObjType>> _poolLists;

		private static Transform _objCacheParent;

		public static T instance => null;

		protected static Transform cacheParent => null;

		protected List<TObjType> GetPoolList(int poolId)
		{
			return null;
		}

		public bool IsEmpty(int poolId)
		{
			return false;
		}

		public TObjType GetObject(int poolId = 0)
		{
			return (TObjType)null;
		}

		public void PreLoadObject(int poolId, int count)
		{
		}

		public void ReturnObject(TObjType obj, int poolId)
		{
		}

		protected abstract TObjType NewObject(int poolId);

		protected abstract void OnObjectAwake(TObjType obj);

		protected abstract void OnObjectSleep(TObjType obj);
	}
}
