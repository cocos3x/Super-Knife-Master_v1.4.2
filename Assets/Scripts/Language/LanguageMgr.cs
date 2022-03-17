using FairyGUI;
using Master;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Language
{
	public class LanguageMgr
	{
		public enum EventType
		{
			OnLanguageChange
		}

		public class Listener : SEventDispatch<EventType>
		{
			public void OnLanguageChange(object objKey, Action callback)
			{
			}
		}

		private class ConfigItem
		{
			public string currentKey;

			public Dictionary<string, string> config;
		}

		private sealed class _003C_003Ec__DisplayClass32_0
		{
			public GTextField aTextField;

			internal void _003CInitTestModeBtn_003Eb__0()
			{
			}
		}

		[StructLayout(3)]
		private struct _003C_003Ec__DisplayClass33_0
		{
			public GComponent obj;

			public LanguageMgr _003C_003E4__this;
		}

		private sealed class _003C_003Ec__DisplayClass34_0
		{
			public LanguageMgr _003C_003E4__this;

			public GObject obj;

			internal void _003CAdd2ObserverDict_003Eb__0()
			{
			}
		}

		public static readonly LanguageMgr Instance;

		private const string TAG = "LanguagePresenter";

		private const char Spilit = '#';

		private const string TextFont = "textFont";

		private const string LanguageName = "languageName";

		private const string TextKey = "textKey";

		private const string SaveKey = "LanguageMgr_languageKey";

		private const string DefaultLanguageKey = "en";

		private static string _languageKey;

		private string InitDefaultFont;

		private bool _hadInit;

		private Dictionary<string, Dictionary<string, string>> _languageConfigDict;

		private Dictionary<string, List<string>> _textKeyList;

		private readonly Dictionary<GObject, ConfigItem> _observerDict;

		public static GComponent _languageTestBtn;

		private static readonly Dictionary<string, string> _003CsupportTypes_003Ek__BackingField;

		public readonly Listener listener;

		private static GComponent m_scene;

		public static Dictionary<string, string> supportTypes => null;

		public bool IsRTLText => false;

		public string curLanguageName => "";

		public static string curLanguageKey
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		private void Init()
		{
		}

		public static void AddObserver(GComponent obj, bool isMainScene = false)
		{
		}

		public static void RemoveObserver(GObject obj)
		{
		}

		private void InitTestModeBtn()
		{
		}

		private void RegisterObserver(GComponent obj)
		{
		}

		private void Add2ObserverDict(GObject obj, Dictionary<string, string> cfg)
		{
		}

		private void OnLanguageChanged()
		{
		}

		private void RefreshDefaultFont()
		{
		}

		public void RefreshFont(GComponent obj)
		{
		}

		public void RefreshText()
		{
		}

		public bool GetTextByKey(string textKey, out string result)
		{
			return false;
		}

		private void InitConfigDict()
		{
		}

		public void SetText(GTextField textField, string textKey)
		{
		}

		public static string GetLanguageText(string key)
		{
			return "";
		}

		public static void SwitchLanguage_Test()
		{
		}

		private void _003CRegisterObserver_003Eg__AddByTextKey1_007C33_0(List<string> list, ref _003C_003Ec__DisplayClass33_0 P_1)
		{
		}
	}
}
