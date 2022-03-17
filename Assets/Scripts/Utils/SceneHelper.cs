using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Utils
{
	public class SceneHelper : MonoBehaviour
	{
		private sealed class _003C_003Ec__DisplayClass5_0
		{
			private sealed class _003C_003CLoadSceneAsync_003Eg__Loading_007C0_003Ed : IEnumerator<object>, IEnumerator, IDisposable
			{
				private int _003C_003E1__state;

				private object _003C_003E2__current;

				public string temp;

				public _003C_003Ec__DisplayClass5_0 _003C_003E4__this;

				private AsyncOperation _003Cscene_003E5__2;

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
				public _003C_003CLoadSceneAsync_003Eg__Loading_007C0_003Ed(int _003C_003E1__state)
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

			public SceneCallback callback;

			public string sceneName;

			internal IEnumerator _003CLoadSceneAsync_003Eg__Loading_007C0(string temp)
			{
				return null;
			}
		}

		public static readonly string TAG;

		private static bool isSceneLoading;

		public static SceneHelper _ins;

		public static SceneHelper instance => null;

		public static bool LoadSceneAsync(string sceneName, string from, [Optional] SceneCallback callback)
		{
			return false;
		}
	}
}
