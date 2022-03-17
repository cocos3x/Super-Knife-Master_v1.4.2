using FairyGUI.Utils;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace FairyGUI
{
	public class UIPackage
	{
		public delegate object LoadResource(string name, string extension, Type type, out DestroyMethod destroyMethod);

		public delegate void LoadResourceAsync(string name, string extension, Type type, PackageItem item);

		public delegate void CreateObjectCallback(GObject result);

		private class AtlasSprite
		{
			public PackageItem atlas;

			public Rect rect;

			public Vector2 offset;

			public Vector2 originalSize;

			public bool rotated;
		}

		private sealed class _003C_003Ec__DisplayClass93_0
		{
			public PackageItem item;

			internal void _003CLoadAtlas_003Eb__0(NTexture t)
			{
			}
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			internal object _003C_002Ecctor_003Eb__101_0(string name, string extension, Type type, out DestroyMethod destroyMethod)
			{
				return null;
			}
		}

		public static bool unloadBundleByFGUI;

		private string _003Cid_003Ek__BackingField;

		private string _003Cname_003Ek__BackingField;

		private List<PackageItem> _items;

		private Dictionary<string, PackageItem> _itemsById;

		private Dictionary<string, PackageItem> _itemsByName;

		private Dictionary<string, string>[] _dependencies;

		private string _assetPath;

		private string[] _branches;

		internal int _branchIndex;

		private AssetBundle _resBundle;

		private string _customId;

		private bool _fromBundle;

		private LoadResource _loadFunc;

		private LoadResourceAsync _loadAsyncFunc;

		private Dictionary<string, AtlasSprite> _sprites;

		private static Dictionary<string, UIPackage> _packageInstById;

		private static Dictionary<string, UIPackage> _packageInstByName;

		private static List<UIPackage> _packageList;

		private static string _branch;

		private static Dictionary<string, string> _vars;

		internal static int _constructing;

		public const string URL_PREFIX = "ui://";

		private static LoadResource _loadFromResourcesPath;

		public string id
		{
			get
			{
				return "";
			}
			private set
			{
			}
		}

		public string name
		{
			get
			{
				return "";
			}
			private set
			{
			}
		}

		public static string branch
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public string assetPath => "";

		public string customId
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public AssetBundle resBundle => null;

		public Dictionary<string, string>[] dependencies => null;

		public static event Action<PackageItem> onReleaseResource
		{
			add
			{
			}
			remove
			{
			}
		}

		public static string GetVar(string key)
		{
			return "";
		}

		public static void SetVar(string key, string value)
		{
		}

		public static UIPackage GetById(string id)
		{
			return null;
		}

		public static UIPackage GetByName(string name)
		{
			return null;
		}

		public static UIPackage AddPackage(AssetBundle bundle)
		{
			return null;
		}

		public static UIPackage AddPackage(AssetBundle desc, AssetBundle res)
		{
			return null;
		}

		public static UIPackage AddPackage(AssetBundle desc, AssetBundle res, string mainAssetName)
		{
			return null;
		}

		public static UIPackage AddPackage(string descFilePath)
		{
			return null;
		}

		public static UIPackage AddPackage(string assetPath, LoadResource loadFunc)
		{
			return null;
		}

		public static UIPackage AddPackage(byte[] descData, string assetNamePrefix, LoadResource loadFunc)
		{
			return null;
		}

		public static UIPackage AddPackage(byte[] descData, string assetNamePrefix, LoadResourceAsync loadFunc)
		{
			return null;
		}

		public static void RemovePackage(string packageIdOrName)
		{
		}

		public static void RemoveAllPackages()
		{
		}

		public static List<UIPackage> GetPackages()
		{
			return null;
		}

		public static GObject CreateObject(string pkgName, string resName)
		{
			return null;
		}

		public static GObject CreateObject(string pkgName, string resName, Type userClass)
		{
			return null;
		}

		public static GObject CreateObjectFromURL(string url)
		{
			return null;
		}

		public static GObject CreateObjectFromURL(string url, Type userClass)
		{
			return null;
		}

		public static void CreateObjectAsync(string pkgName, string resName, CreateObjectCallback callback)
		{
		}

		public static void CreateObjectFromURL(string url, CreateObjectCallback callback)
		{
		}

		public static object GetItemAsset(string pkgName, string resName)
		{
			return null;
		}

		public static object GetItemAssetByURL(string url)
		{
			return null;
		}

		public static string GetItemURL(string pkgName, string resName)
		{
			return "";
		}

		public static PackageItem GetItemByURL(string url)
		{
			return null;
		}

		public static string NormalizeURL(string url)
		{
			return "";
		}

		public static void SetStringsSource(XML source)
		{
		}

		private bool LoadPackage(ByteBuffer buffer, string assetNamePrefix)
		{
			return false;
		}

		private static int ComparePackageItem(PackageItem p1, PackageItem p2)
		{
			return 0;
		}

		public void LoadAllAssets()
		{
		}

		public void UnloadAssets()
		{
		}

		public void ReloadAssets()
		{
		}

		public void ReloadAssets(AssetBundle resBundle)
		{
		}

		private void Dispose()
		{
		}

		public GObject CreateObject(string resName)
		{
			return null;
		}

		public GObject CreateObject(string resName, Type userClass)
		{
			return null;
		}

		public void CreateObjectAsync(string resName, CreateObjectCallback callback)
		{
		}

		private GObject CreateObject(PackageItem item, Type userClass)
		{
			return null;
		}

		public object GetItemAsset(string resName)
		{
			return null;
		}

		public List<PackageItem> GetItems()
		{
			return null;
		}

		public PackageItem GetItem(string itemId)
		{
			return null;
		}

		public PackageItem GetItemByName(string itemName)
		{
			return null;
		}

		public object GetItemAsset(PackageItem item)
		{
			return null;
		}

		public void SetItemAsset(PackageItem item, object asset, DestroyMethod destroyMethod)
		{
		}

		private void LoadAtlas(PackageItem item)
		{
		}

		private void LoadImage(PackageItem item)
		{
		}

		private void LoadSound(PackageItem item)
		{
		}

		private byte[] LoadBinary(PackageItem item)
		{
			return null;
		}

		private void LoadMovieClip(PackageItem item)
		{
		}

		private void LoadFont(PackageItem item)
		{
		}

		private void LoadSpine(PackageItem item)
		{
		}

		private void LoadDragonBones(PackageItem item)
		{
		}
	}
}
