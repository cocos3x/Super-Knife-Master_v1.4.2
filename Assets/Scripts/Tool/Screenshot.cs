using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace Tool
{
	public class Screenshot : MonoBehaviour
	{
		private sealed class _003CRecordFrame_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Screenshot _003C_003E4__this;

			public string fileName;

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
			public _003CRecordFrame_003Ed__5(int _003C_003E1__state)
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

		private bool _needSave;

		private string _fileName;

		private static Screenshot _instance;

		public static Screenshot Instance => null;

		private IEnumerator RecordFrame(string fileName)
		{
			return null;
		}

		public void LateUpdate()
		{
		}

		private Texture2D ScaleTexture(Texture2D source, int targetWidth, int targetHeight)
		{
			return null;
		}

		public static void OutputTexture(RenderTexture rt, string idx)
		{
		}

		public void SaveJpg(string jpg)
		{
		}
	}
}
