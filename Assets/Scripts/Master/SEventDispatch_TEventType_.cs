using System;

namespace Master
{
	public class SEventDispatch<TEventType> : ISRemoveAbleContainer
	{
		protected readonly SLockList<TEventType, Action> items;

		public virtual void Add(object objKey, TEventType eventType, Action callback)
		{
		}

		public virtual void Remove(object objKey)
		{
		}

		public void EmitEvent(TEventType eventType)
		{
		}
	}
}
