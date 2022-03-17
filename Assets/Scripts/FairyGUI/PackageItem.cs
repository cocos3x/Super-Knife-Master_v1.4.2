using FairyGUI.Utils;
using UnityEngine;

namespace FairyGUI
{
	public class PackageItem
	{
		public UIPackage owner;

		public PackageItemType type;

		public ObjectType objectType;

		public string id;

		public string name;

		public int width;

		public int height;

		public string file;

		public bool exported;

		public NTexture texture;

		public ByteBuffer rawData;

		public string[] branches;

		public string[] highResolution;

		public Rect? scale9Grid;

		public bool scaleByTile;

		public int tileGridIndice;

		public PixelHitTestData pixelHitTestData;

		public float interval;

		public float repeatDelay;

		public bool swing;

		public MovieClip.Frame[] frames;

		public bool translated;

		public UIObjectFactory.GComponentCreator extensionCreator;

		public BitmapFont bitmapFont;

		public NAudioClip audioClip;

		public Vector2 skeletonAnchor;

		public object skeletonAsset;

		public object Load()
		{
			return null;
		}

		public PackageItem getBranch()
		{
			return null;
		}

		public PackageItem getHighResolution()
		{
			return null;
		}
	}
}
