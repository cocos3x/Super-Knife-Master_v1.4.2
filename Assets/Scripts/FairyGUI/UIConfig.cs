using System;
using System.Collections.Generic;
using UnityEngine;

namespace FairyGUI
{
	public class UIConfig : MonoBehaviour
	{
		public enum ConfigKey
		{
			DefaultFont = 0,
			ButtonSound = 1,
			ButtonSoundVolumeScale = 2,
			HorizontalScrollBar = 3,
			VerticalScrollBar = 4,
			DefaultScrollStep = 5,
			DefaultScrollBarDisplay = 6,
			DefaultScrollTouchEffect = 7,
			DefaultScrollBounceEffect = 8,
			TouchScrollSensitivity = 9,
			WindowModalWaiting = 10,
			GlobalModalWaiting = 11,
			PopupMenu = 12,
			PopupMenu_seperator = 13,
			LoaderErrorSign = 14,
			TooltipsWin = 0xF,
			DefaultComboBoxVisibleItemCount = 0x10,
			TouchDragSensitivity = 17,
			ClickDragSensitivity = 18,
			ModalLayerColor = 19,
			RenderingTextBrighterOnDesktop = 20,
			AllowSoftnessOnTopOrLeftSide = 21,
			InputCaretSize = 22,
			InputHighlightColor = 23,
			EnhancedTextOutlineEffect = 24,
			DepthSupportForPaintingMode = 25,
			RichTextRowVerticalAlign = 26,
			Branch = 27,
			PleaseSelect = 100
		}

		[Serializable]
		public class ConfigValue
		{
			public bool valid;

			public string s;

			public int i;

			public float f;

			public bool b;

			public Color c;

			public void Reset()
			{
			}
		}

		public delegate NAudioClip SoundLoader(string url);

		public static string defaultFont;

		public static bool renderingTextBrighterOnDesktop;

		public static string windowModalWaiting;

		public static string globalModalWaiting;

		public static Color modalLayerColor;

		public static NAudioClip buttonSound;

		public static float buttonSoundVolumeScale;

		public static string horizontalScrollBar;

		public static string verticalScrollBar;

		public static float defaultScrollStep;

		public static float defaultScrollDecelerationRate;

		public static ScrollBarDisplayType defaultScrollBarDisplay;

		public static bool defaultScrollTouchEffect;

		public static bool defaultScrollBounceEffect;

		public static string popupMenu;

		public static string popupMenu_seperator;

		public static string loaderErrorSign;

		public static string tooltipsWin;

		public static int defaultComboBoxVisibleItemCount;

		public static int touchScrollSensitivity;

		public static int touchDragSensitivity;

		public static int clickDragSensitivity;

		public static bool allowSoftnessOnTopOrLeftSide;

		public static bool bringWindowToFrontOnClick;

		public static float inputCaretSize;

		public static Color inputHighlightColor;

		public static float frameTimeForAsyncUIConstruction;

		public static bool depthSupportForPaintingMode;

		public static bool enhancedTextOutlineEffect;

		public static VertAlignType richTextRowVerticalAlign;

		public static bool makePixelPerfect;

		public List<ConfigValue> Items;

		public List<string> PreloadPackages;

		public static SoundLoader soundLoader;

		private void Awake()
		{
		}

		public void Load()
		{
		}

		public static void SetDefaultValue(ConfigKey key, ConfigValue value)
		{
		}

		public static void ClearResourceRefs()
		{
		}

		public void ApplyModifiedProperties()
		{
		}
	}
}
