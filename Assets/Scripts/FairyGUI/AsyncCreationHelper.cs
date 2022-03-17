using FairyGUI.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace FairyGUI
{
	public class AsyncCreationHelper
	{
		private class DisplayListItem
		{
			public PackageItem packageItem;

			public ObjectType type;

			public int childCount;

			public int listItemCount;

			public DisplayListItem(PackageItem pi, ObjectType type)
			{
			}
		}

		private sealed class _003C_CreateObject_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PackageItem item;

			public UIPackage.CreateObjectCallback callback;

			private float _003CframeTime_003E5__2;

			private List<DisplayListItem> _003CitemList_003E5__3;

			private int _003Ccnt_003E5__4;

			private List<GObject> _003CobjectPool_003E5__5;

			private int _003Ci_003E5__6;

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
			public _003C_CreateObject_003Ed__1(int _003C_003E1__state)
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

		public static void CreateObject(PackageItem item, UIPackage.CreateObjectCallback callback)
		{
		}

		private static IEnumerator _CreateObject(PackageItem item, UIPackage.CreateObjectCallback callback)
		{
			return null;
		}

		private static int CollectComponentChildren(PackageItem item, List<DisplayListItem> list)
		{
			return 0;
		}

		private static int CollectListChildren(ByteBuffer buffer, List<DisplayListItem> list)
		{
			return 0;
		}
	}
}
