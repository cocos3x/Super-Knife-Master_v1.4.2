using FairyGUI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class XRedeemObjPool
{
	public class GPoolComponent : MonoBehaviour
	{
	}

	private sealed class _003CLoadObj_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string url;

		public XRedeemObjPool _003C_003E4__this;

		public int count;

		private int _003Ci_003E5__2;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
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
		public _003CLoadObj_003Ed__12(int _003C_003E1__state)
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

	private Dictionary<string, Queue<GObject>> _pool;

	private static XRedeemObjPool _instance;

	private static Transform _manager;

	private static GPoolComponent _preloadHelper;

	public static GPoolComponent preloadHelper => null;

	public static XRedeemObjPool instance => null;

	public GObject GetObject(string url)
	{
		return null;
	}

	private void ResetAttr(GComponent obj)
	{
	}

	public void PreloadObject(string url, int count)
	{
	}

	private IEnumerator LoadObj(string url, int count)
	{
		return null;
	}

	public void Clear()
	{
	}

	private GObject CreateObject(string url)
	{
		return null;
	}

	public void ReturnObject(GObject obj)
	{
	}
}
