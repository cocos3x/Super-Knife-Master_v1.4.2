using FairyGUI;
using Master;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace Loading
{
	public class LoadingSceneUI : MonoBehaviour
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static LoadingPrivacyDialog.OnCancelEnter _003C_003E9__27_0;

			internal void _003CCheckFinishLoading_003Eb__27_0()
			{
			}
		}

		private sealed class _003CLoadMainScene_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LoadingSceneUI _003C_003E4__this;

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
			public _003CLoadMainScene_003Ed__28(int _003C_003E1__state)
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

		private const string TAG = "LoadingScene";

		private readonly STimer _timer;

		private GComponent _view;

		private GProgressBar _progress;

		private GButton _agreeBtn;

		private bool _hasFinishLoadAssets;

		private bool _hasSwitchScene;

		private bool _hasFinishProgress;

		private bool _hasSDKLoadingReady;

		private int _timeNeedForLoad;

		private int _enterGameCount;

		private int _timeRunFromStart;

		private bool _agreeTicked;

		private int _checkInterval;

		private AsyncOperation _load;

		private bool _allowSwitchScene;

		private bool _switchSceneFinish;

		private long _startLoadTick;

		private bool _isLoadSceneFinish;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void Start()
		{
		}

		private void ShowBarAction(float time)
		{
		}

		private void ClickTicked()
		{
		}

		private void HidePolicyGroup()
		{
		}

		private void UpdateEnterCount()
		{
		}

		private void SaveGdprData()
		{
		}

		private void CheckFinishLoading()
		{
		}

		private IEnumerator LoadMainScene()
		{
			return null;
		}

		private void ClickText(string linkTag)
		{
		}

		private void OnDestroy()
		{
		}

		private void _003CStart_003Eb__21_0()
		{
		}

		private void _003CStart_003Eb__21_1(EventContext context)
		{
		}

		private void _003CStart_003Eb__21_2(EventContext context)
		{
		}

		private void _003CStart_003Eb__21_3()
		{
		}

		private void _003CShowBarAction_003Eb__22_0()
		{
		}

		private void _003CCheckFinishLoading_003Eb__27_1()
		{
		}
	}
}
