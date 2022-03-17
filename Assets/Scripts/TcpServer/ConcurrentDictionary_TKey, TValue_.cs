using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace TcpServer
{
	[Serializable]
	public class ConcurrentDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection
	{
		private class Node
		{
			internal TKey m_key;

			internal TValue m_value;

			internal Node m_next;

			internal int m_hashcode;

			internal Node(TKey key, TValue value, int hashcode)
			{
			}

			internal Node(TKey key, TValue value, int hashcode, Node next)
			{
			}
		}

		private class DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
		{
			private IEnumerator<KeyValuePair<TKey, TValue>> m_enumerator;

			public DictionaryEntry Entry => (DictionaryEntry)null;

			public object Key => null;

			public object Value => null;

			public object Current => null;

			internal DictionaryEnumerator(ConcurrentDictionary<TKey, TValue> dictionary)
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
			}
		}

		private sealed class _003CGetEnumerator_003Ed__29 : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private KeyValuePair<TKey, TValue> _003C_003E2__current;

			public ConcurrentDictionary<TKey, TValue> _003C_003E4__this;

			private Node[] _003Cbuckets_003E5__2;

			private int _003Ci_003E5__3;

			private Node _003Ccurrent_003E5__4;

			private KeyValuePair<TKey, TValue> System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CTKey_002CTValue_003E_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return (KeyValuePair<TKey, TValue>)null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CGetEnumerator_003Ed__29(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[NonSerialized]
		private Node[] m_buckets;

		[NonSerialized]
		private object[] m_locks;

		[NonSerialized]
		private int[] m_countPerLock;

		private IEqualityComparer<TKey> m_comparer;

		private KeyValuePair<TKey, TValue>[] m_serializationArray;

		private int m_serializationConcurrencyLevel;

		private int m_serializationCapacity;

		private const int DEFAULT_CONCURRENCY_MULTIPLIER = 4;

		private const int DEFAULT_CAPACITY = 31;

		public TValue this[TKey key]
		{
			get
			{
				return (TValue)null;
			}
			set
			{
			}
		}

		public int Count => 0;

		public bool IsEmpty => false;

		public ICollection<TKey> Keys => null;

		public ICollection<TValue> Values => null;

		private bool System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CTKey_002CTValue_003E_003E_002EIsReadOnly => false;

		private bool System_002ECollections_002EIDictionary_002EIsFixedSize => false;

		private bool System_002ECollections_002EIDictionary_002EIsReadOnly => false;

		private ICollection System_002ECollections_002EIDictionary_002EKeys => null;

		private ICollection System_002ECollections_002EIDictionary_002EValues => null;

		private object System_002ECollections_002EIDictionary_002EItem
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private bool System_002ECollections_002EICollection_002EIsSynchronized => false;

		private object System_002ECollections_002EICollection_002ESyncRoot => null;

		private static int DefaultConcurrencyLevel => 0;

		public ConcurrentDictionary()
		{
		}

		public ConcurrentDictionary(int concurrencyLevel, int capacity)
		{
		}

		public ConcurrentDictionary(IEnumerable<KeyValuePair<TKey, TValue>> collection)
		{
		}

		public ConcurrentDictionary(IEqualityComparer<TKey> comparer)
		{
		}

		public ConcurrentDictionary(IEnumerable<KeyValuePair<TKey, TValue>> collection, IEqualityComparer<TKey> comparer)
		{
		}

		public ConcurrentDictionary(int concurrencyLevel, IEnumerable<KeyValuePair<TKey, TValue>> collection, IEqualityComparer<TKey> comparer)
		{
		}

		private void InitializeFromCollection(IEnumerable<KeyValuePair<TKey, TValue>> collection)
		{
		}

		public ConcurrentDictionary(int concurrencyLevel, int capacity, IEqualityComparer<TKey> comparer)
		{
		}

		public bool TryAdd(TKey key, TValue value)
		{
			return false;
		}

		public bool ContainsKey(TKey key)
		{
			return false;
		}

		public bool TryRemove(TKey key, out TValue value)
		{
			return false;
		}

		private bool TryRemoveInternal(TKey key, out TValue value, bool matchValue, TValue oldValue)
		{
			return false;
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			return false;
		}

		public bool TryUpdate(TKey key, TValue newValue, TValue comparisonValue)
		{
			return false;
		}

		public void Clear()
		{
		}

		private void System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CTKey_002CTValue_003E_003E_002ECopyTo(KeyValuePair<TKey, TValue>[] array, int index)
		{
		}

		public KeyValuePair<TKey, TValue>[] ToArray()
		{
			return null;
		}

		private void CopyToPairs(KeyValuePair<TKey, TValue>[] array, int index)
		{
		}

		private void CopyToEntries(DictionaryEntry[] array, int index)
		{
		}

		private void CopyToObjects(object[] array, int index)
		{
		}

		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		private bool TryAddInternal(TKey key, TValue value, bool updateIfExists, bool acquireLock, out TValue resultingValue)
		{
			return false;
		}

		public TValue GetOrAdd(TKey key, Func<TKey, TValue> valueFactory)
		{
			return (TValue)null;
		}

		public TValue GetOrAdd(TKey key, TValue value)
		{
			return (TValue)null;
		}

		public TValue AddOrUpdate(TKey key, Func<TKey, TValue> addValueFactory, Func<TKey, TValue, TValue> updateValueFactory)
		{
			return (TValue)null;
		}

		public TValue AddOrUpdate(TKey key, TValue addValue, Func<TKey, TValue, TValue> updateValueFactory)
		{
			return (TValue)null;
		}

		private void System_002ECollections_002EGeneric_002EIDictionary_003CTKey_002CTValue_003E_002EAdd(TKey key, TValue value)
		{
		}

		private bool System_002ECollections_002EGeneric_002EIDictionary_003CTKey_002CTValue_003E_002ERemove(TKey key)
		{
			return false;
		}

		private void System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CTKey_002CTValue_003E_003E_002EAdd(KeyValuePair<TKey, TValue> keyValuePair)
		{
		}

		private bool System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CTKey_002CTValue_003E_003E_002EContains(KeyValuePair<TKey, TValue> keyValuePair)
		{
			return false;
		}

		private bool System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CTKey_002CTValue_003E_003E_002ERemove(KeyValuePair<TKey, TValue> keyValuePair)
		{
			return false;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		private void System_002ECollections_002EIDictionary_002EAdd(object key, object value)
		{
		}

		private bool System_002ECollections_002EIDictionary_002EContains(object key)
		{
			return false;
		}

		private IDictionaryEnumerator System_002ECollections_002EIDictionary_002EGetEnumerator()
		{
			return null;
		}

		private void System_002ECollections_002EIDictionary_002ERemove(object key)
		{
		}

		private void System_002ECollections_002EICollection_002ECopyTo(Array array, int index)
		{
		}

		private void GrowTable(Node[] buckets)
		{
		}

		private void GetBucketAndLockNo(int hashcode, out int bucketNo, out int lockNo, int bucketCount)
		{
		}

		private void AcquireAllLocks(ref int locksAcquired)
		{
		}

		private void AcquireLocks(int fromInclusive, int toExclusive, ref int locksAcquired)
		{
		}

		private void ReleaseLocks(int fromInclusive, int toExclusive)
		{
		}

		private ReadOnlyCollection<TKey> GetKeys()
		{
			return null;
		}

		private ReadOnlyCollection<TValue> GetValues()
		{
			return null;
		}

		private void Assert(bool condition)
		{
		}

		private string GetResource(string key)
		{
			return "";
		}

		private void OnSerializing(StreamingContext context)
		{
		}

		private void OnDeserialized(StreamingContext context)
		{
		}
	}
}
