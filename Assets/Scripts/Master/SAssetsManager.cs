using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace Master
{
	public class SAssetsManager
	{
		[Serializable]
		private class AssetBuildResult
		{
			public string[] allAssetBundleNames;
		}

		public sealed class AssetLoadRequest : CustomYieldInstruction
		{
			public bool isFinish;

			public string name;

			public override bool keepWaiting => false;
		}

		private class AssetInfo
		{
			public UnityEngine.Object assetObj;

			public string bundleName;
		}

		private sealed class _003CLoadAllBundleAsync_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SAssetsManager _003C_003E4__this;

			private List<string>.Enumerator _003C_003E7__wrap1;

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
			public _003CLoadAllBundleAsync_003Ed__15(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		private sealed class _003CLoadBundleAsync_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SAssetsManager _003C_003E4__this;

			public string[] bundleNameList;

			private Dictionary<string, int> _003CbundleMaps_003E5__2;

			private string[] _003C_003E7__wrap2;

			private int _003C_003E7__wrap3;

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
			public _003CLoadBundleAsync_003Ed__16(int _003C_003E1__state)
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

		private sealed class _003CLoadBundleAsync_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AssetLoadRequest assetLoadQuest;

			public SAssetsManager _003C_003E4__this;

			private string _003CbundleName_003E5__2;

			private int _003CencryptTag_003E5__3;

			private AssetBundleCreateRequest _003Crequest_003E5__4;

			private AssetBundleRequest _003CassetsRequest_003E5__5;

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
			public _003CLoadBundleAsync_003Ed__19(int _003C_003E1__state)
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

		private static readonly SAssetsManager _003Cinstance_003Ek__BackingField;

		private readonly Dictionary<string, AssetBundle> _bundles;

		private readonly Dictionary<string, int> _bundleNameTags;

		private readonly Dictionary<string, AssetInfo> _allAssets;

		private bool _isLoadedStreamingAssets;

		private string[] _assetBundleNameList;

		private bool _loadFromAssetDatabase;

		public static SAssetsManager instance => null;

		public static string webStreamingAssetsPath => "";

		private void LoadStreamingAssets()
		{
		}

		public IEnumerator LoadAllBundleAsync()
		{
			return null;
		}

		public IEnumerator LoadBundleAsync(string[] bundleNameList)
		{
			return null;
		}

		public bool isBundleLoaded(string bundleName)
		{
			return false;
		}

		public AssetBundle LoadBundle(string bundleName)
		{
			return null;
		}

		public IEnumerator LoadBundleAsync(AssetLoadRequest assetLoadQuest)
		{
			return null;
		}

		public UnityEngine.Object LoadFuiAsset(string fileName, string extension, Type type)
		{
			return null;
		}

		private UnityEngine.Object LoadResourceFromAssetDatabase(string name, Type type)
		{
			return null;
		}

		public TextAsset LoadJsonMetaAsset(string fileName)
		{
			return null;
		}
	}
}
