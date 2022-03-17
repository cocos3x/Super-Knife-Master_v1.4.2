using FairyGUI;
using Master;
using Presenter;
using Reward;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Test
{
	public class TestModeDialog : SDialogX<TestModeDialog>
	{
		private class LineEntry
		{
			public Func<string> func;

			public Func<string> other;

			public GLabel lable;
		}

		private sealed class _003C_003Ec__DisplayClass6_0
		{
			public RewardPresenter reward;

			public CalculatePresenter calc;

			public TestModeDialog _003C_003E4__this;

			internal string _003COnEnter_003Eb__0()
			{
				return "";
			}

			internal void _003COnEnter_003Eb__1()
			{
			}

			internal string _003COnEnter_003Eb__2()
			{
				return "";
			}

			internal void _003COnEnter_003Eb__3()
			{
			}

			internal void _003COnEnter_003Eb__7()
			{
			}

			internal void _003COnEnter_003Eb__8()
			{
			}

			internal void _003COnEnter_003Eb__9()
			{
			}

			internal void _003COnEnter_003Eb__10()
			{
			}

			internal void _003COnEnter_003Eb__11()
			{
			}

			internal void _003COnEnter_003Eb__12()
			{
			}

			internal void _003COnEnter_003Eb__13()
			{
			}

			internal void _003COnEnter_003Eb__14()
			{
			}

			internal void _003COnEnter_003Eb__15()
			{
			}

			internal void _003COnEnter_003Eb__16()
			{
			}

			internal void _003COnEnter_003Eb__17()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass6_1
		{
			public float l;

			public _003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals1;

			internal void _003COnEnter_003Eb__39()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass6_2
		{
			public float v;

			public _003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals2;

			internal void _003COnEnter_003Eb__40()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass6_3
		{
			public string l;

			internal void _003COnEnter_003Eb__41()
			{
			}
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Func<string> _003C_003E9__6_4;

			public static EventCallback0 _003C_003E9__6_5;

			public static Func<string> _003C_003E9__6_6;

			public static EventCallback0 _003C_003E9__6_18;

			public static EventCallback0 _003C_003E9__6_19;

			public static EventCallback0 _003C_003E9__6_20;

			public static EventCallback0 _003C_003E9__6_21;

			public static EventCallback0 _003C_003E9__6_22;

			public static EventCallback0 _003C_003E9__6_23;

			public static EventCallback0 _003C_003E9__6_24;

			public static EventCallback0 _003C_003E9__6_25;

			public static EventCallback0 _003C_003E9__6_26;

			public static EventCallback0 _003C_003E9__6_27;

			public static EventCallback0 _003C_003E9__6_28;

			public static EventCallback0 _003C_003E9__6_29;

			public static EventCallback0 _003C_003E9__6_30;

			public static EventCallback0 _003C_003E9__6_31;

			public static EventCallback0 _003C_003E9__6_32;

			public static EventCallback0 _003C_003E9__6_33;

			public static EventCallback0 _003C_003E9__6_34;

			public static Func<string> _003C_003E9__6_35;

			public static EventCallback0 _003C_003E9__6_36;

			public static EventCallback0 _003C_003E9__6_37;

			public static Func<string> _003C_003E9__6_38;

			internal string _003COnEnter_003Eb__6_4()
			{
				return "";
			}

			internal void _003COnEnter_003Eb__6_5()
			{
			}

			internal string _003COnEnter_003Eb__6_6()
			{
				return "";
			}

			internal void _003COnEnter_003Eb__6_18()
			{
			}

			internal void _003COnEnter_003Eb__6_19()
			{
			}

			internal void _003COnEnter_003Eb__6_20()
			{
			}

			internal void _003COnEnter_003Eb__6_21()
			{
			}

			internal void _003COnEnter_003Eb__6_22()
			{
			}

			internal void _003COnEnter_003Eb__6_23()
			{
			}

			internal void _003COnEnter_003Eb__6_24()
			{
			}

			internal void _003COnEnter_003Eb__6_25()
			{
			}

			internal void _003COnEnter_003Eb__6_26()
			{
			}

			internal void _003COnEnter_003Eb__6_27()
			{
			}

			internal void _003COnEnter_003Eb__6_28()
			{
			}

			internal void _003COnEnter_003Eb__6_29()
			{
			}

			internal void _003COnEnter_003Eb__6_30()
			{
			}

			internal void _003COnEnter_003Eb__6_31()
			{
			}

			internal void _003COnEnter_003Eb__6_32()
			{
			}

			internal void _003COnEnter_003Eb__6_33()
			{
			}

			internal void _003COnEnter_003Eb__6_34()
			{
			}

			internal string _003COnEnter_003Eb__6_35()
			{
				return "";
			}

			internal void _003COnEnter_003Eb__6_36()
			{
			}

			internal void _003COnEnter_003Eb__6_37()
			{
			}

			internal string _003COnEnter_003Eb__6_38()
			{
				return "";
			}
		}

		private sealed class _003C_003Ec__DisplayClass12_0
		{
			public string key;

			public TestModeDialog _003C_003E4__this;

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

			public TestModeDialog _003C_003E4__this;

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

		protected override void OnInit()
		{
		}

		protected override void OnEnter()
		{
		}

		private void SetTestLv(int lv)
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

		private void AddTestBtn(string title, EventCallback0 callback, bool autoClose = false)
		{
		}

		private void AddSwitchBtn(string title, Action<bool> callback)
		{
		}

		protected override void OnUpdate()
		{
		}
	}
}
