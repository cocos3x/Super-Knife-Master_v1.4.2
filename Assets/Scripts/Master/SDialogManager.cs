using System;
using System.Collections.Generic;

namespace Master
{
	public class SDialogManager
	{
		private static SDialogManager s_instance;

		private Dictionary<string, SDialog> _dialogs;

		private readonly List<Action> _waitCreateDialogList;

		private float _emptyDialogDuration;

		public static SDialogManager instance => null;

		public bool hasAnyDialog => false;

		private SDialogManager()
		{
		}

		public T OpenDialog<T>(params object[] args) where T : SDialog
		{
			return null;
		}

		public void OnDialogOpen(SDialog dialog)
		{
		}

		public void OnDialogClose(SDialog dialog)
		{
		}

		public T GetDialog<T>() where T : SDialog
		{
			return null;
		}

		public bool HasDialog<T>() where T : SDialog
		{
			return false;
		}

		public void CloseDialog<T>() where T : SDialog
		{
		}

		public void CloseAllDialog()
		{
		}

		public void Clear()
		{
		}

		public void AddDialogToWaitList(Action callback)
		{
		}

		public void CheckDialogWaitList()
		{
		}

		public void Update()
		{
		}
	}
}
