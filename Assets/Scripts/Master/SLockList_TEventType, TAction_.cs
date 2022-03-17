using System;
using System.Collections;
using System.Collections.Generic;

namespace Master
{
	public class SLockList<TEventType, TAction>
	{
		private class DelayAddEntry
		{
			internal object _objKey;

			internal TEventType _eventKey;

			internal TAction _callback;
		}

		private class EventNodePair
		{
			internal TEventType _eventKey;

			internal LinkedListNode<TAction> _node;
		}

		public struct IterList : IEnumerable<TAction>, IEnumerable
		{
			public struct Enumerator : IEnumerator<TAction>, IEnumerator, IDisposable
			{
				private readonly IterList _owner;

				private LinkedListNode<TAction> _node;

				private int _index;

				private TAction _current;

				public TAction Current => (TAction)null;

				private object System_002ECollections_002EIEnumerator_002ECurrent => null;

				internal Enumerator(IterList owner)
				{
				}

				public void Dispose()
				{
				}

				public bool MoveNext()
				{
					return false;
				}

				private void System_002ECollections_002EIEnumerator_002EReset()
				{
				}
			}

			internal SLockList<TEventType, TAction> parent;

			internal LinkedList<TAction> list;

			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}

			public IEnumerator<TAction> GetEnumerator()
			{
				return null;
			}
		}

		private readonly List<LinkedList<TAction>> _callbackLists;

		private readonly Dictionary<object, List<EventNodePair>> _items;

		private List<DelayAddEntry> _delayAddList;

		private List<object> _delayRemoveList;

		private bool _isLock;

		public IterList this[TEventType eventType] => (IterList)null;

		public void Begin()
		{
		}

		public void End()
		{
		}

		public void Add(object objKey, TEventType eventType, TAction callback)
		{
		}

		public void CheckAddAndRemove()
		{
		}

		public void Remove(object objKey)
		{
		}
	}
}
