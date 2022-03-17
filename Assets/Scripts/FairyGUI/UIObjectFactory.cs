using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace FairyGUI
{
	public class UIObjectFactory
	{
		public delegate GComponent GComponentCreator();

		public delegate GLoader GLoaderCreator();

		private sealed class _003C_003Ec__DisplayClass4_0
		{
			public Type type;

			internal GComponent _003CSetPackageItemExtension_003Eb__0()
			{
				return null;
			}
		}

		private sealed class _003C_003Ec__DisplayClass6_0
		{
			public Type type;

			internal GLoader _003CSetLoaderExtension_003Eb__0()
			{
				return null;
			}
		}

		private static Dictionary<string, GComponentCreator> packageItemExtensions;

		private static GLoaderCreator loaderCreator;

		public static void SetPackageItemExtension(string url, Type type)
		{
		}

		public static void SetPackageItemExtension(string url, GComponentCreator creator)
		{
		}

		public static void SetLoaderExtension(Type type)
		{
		}

		public static void SetLoaderExtension(GLoaderCreator creator)
		{
		}

		internal static void ResolvePackageItemExtension(PackageItem pi)
		{
		}

		public static void Clear()
		{
		}

		public static GObject NewObject(PackageItem pi, [Optional] Type userClass)
		{
			return null;
		}

		public static GObject NewObject(ObjectType type)
		{
			return null;
		}
	}
}
