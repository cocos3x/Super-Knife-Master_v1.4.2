using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Master
{
	public class STimer
	{
		private class TimerNode
		{
			internal TimerNode _next;

			internal TimerNode _prev;

			internal float _interval;

			internal float _passTime;

			internal string _key;

			internal int _runIndex;

			internal int _runCount;

			internal Action _listener;

			internal bool _disposed;

			internal bool _running;

			internal bool _tagToAdd;
		}

		private bool _isLocked;

		private TimerNode _head;

		private TimerNode _tail;

		private Dictionary<string, TimerNode> _timers;

		private List<TimerNode> _delayAddList;

		private int _count;

		private List<TimerNode> delayAddList => null;

		public int Count => 0;

		public void Clear()
		{
		}

		private void AddNode(TimerNode node)
		{
		}

		private void RemoveNode(TimerNode node)
		{
		}

		public void SetTimer(float interval, Action callback, [Optional] string key, int runCount = 1)
		{
		}

		public void RemoveTimer(string key)
		{
		}

		public void PauseTimerByKey(string key)
		{
		}

		public void ResumeTimerByKey(string key)
		{
		}

		private void StepTimer(TimerNode node, float delta)
		{
		}

		public void Update(float delta)
		{
		}

		public void ReClock(string key)
		{
		}

		public void SetInterval(string key, float interval)
		{
		}

		public void SetPassTime(string key, float passTime)
		{
		}

		public void CallTimer(string key)
		{
		}

		public int GetRunIndex(string key)
		{
			return 0;
		}

		public bool HasTimer(string key)
		{
			return false;
		}
	}
}
