using Configure.CoreData;
using FairyGUI;
using Master;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace XREDEEM
{
	public class XRedeemTestModeDialog : SDialog
	{
		private class LineEntry
		{
			public Func<string> func;

			public Func<string> other;

			public GLabel lable;
		}

		private sealed class _003C_003Ec__DisplayClass7_0
		{
			public GameCoreConfig coreCfg;

			public XRedeemTestModeDialog _003C_003E4__this;

			public GTextInput gamesInput;

			internal string _003COnEnter_003Eb__0()
			{
				return "";
			}

			internal void _003COnEnter_003Eb__7()
			{
			}

			internal void _003COnEnter_003Eb__8()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass7_1
		{
			public int v;

			public _003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals1;

			internal void _003COnEnter_003Eb__9()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass7_2
		{
			public int testVersion;

			internal void _003COnEnter_003Eb__10()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass7_3
		{
			public float d;

			internal void _003COnEnter_003Eb__11()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass7_4
		{
			public float g;

			internal void _003COnEnter_003Eb__12()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass7_5
		{
			public SkinRewardGroup node;

			internal void _003COnEnter_003Eb__13()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass7_6
		{
			public float f;

			public _003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals2;

			internal void _003COnEnter_003Eb__14()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass7_7
		{
			public int col;

			internal void _003COnEnter_003Eb__15()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass7_8
		{
			public string str;

			public _003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals3;

			internal void _003COnEnter_003Eb__16()
			{
			}
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static EventCallback0 _003C_003E9__7_1;

			public static EventCallback0 _003C_003E9__7_2;

			public static EventCallback0 _003C_003E9__7_3;

			public static EventCallback0 _003C_003E9__7_4;

			public static EventCallback0 _003C_003E9__7_5;

			public static EventCallback0 _003C_003E9__7_6;

			internal void _003COnEnter_003Eb__7_1()
			{
			}

			internal void _003COnEnter_003Eb__7_2()
			{
			}

			internal void _003COnEnter_003Eb__7_3()
			{
			}

			internal void _003COnEnter_003Eb__7_4()
			{
			}

			internal void _003COnEnter_003Eb__7_5()
			{
			}

			internal void _003COnEnter_003Eb__7_6()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass12_0
		{
			public string key;

			public XRedeemTestModeDialog _003C_003E4__this;

			public GLabel line;

			public Func<string> value;

			internal void _003CAddLine_003Eb__0()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass13_0
		{
			public EventCallback0 callback;

			public bool autoClose;

			public XRedeemTestModeDialog _003C_003E4__this;

			internal void _003CAddTestBtn_003Eb__0()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass14_0
		{
			public bool isSelected;

			public GButton btn;

			public Action<bool> callback;

			internal void _003CAddSwitchBtn_003Eb__0()
			{
			}
		}

		private string _pkgName;

		private GList _listView;

		private Dictionary<string, LineEntry> _lines;

		private readonly List<Action> _actions;

		public static bool HideTestBtn;

		protected override void OnInit()
		{
		}

		protected override void OnEnter()
		{
		}

		protected override void OnExit()
		{
		}

		protected override void InitTouchListener()
		{
		}

		private void ShowOtherInfo(string key, Func<string> other)
		{
		}

		private void AddLine(string title)
		{
		}

		private void AddLine(Func<string> value, [Optional] string key)
		{
		}

		private void AddTestBtn(string title, [Optional] EventCallback0 callback, bool autoClose = false)
		{
		}

		private void AddSwitchBtn(string title, Action<bool> callback)
		{
		}

		private GTextInput AddTestInput(string title, [Optional] EventCallback0 callback, bool autoClose = false)
		{
			return null;
		}

		protected override void OnUpdate()
		{
		}
	}
}
