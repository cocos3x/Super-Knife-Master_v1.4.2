using FairyGUI;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Master
{
	public static class SFairyGUIExtend
	{
		private sealed class _003C_003Ec__DisplayClass28_0
		{
			public GButton btn;

			public float clickInterval;

			public EventCallback0 callback;

			internal void _003CAddButtonClick_003Eb__0()
			{
			}

			internal void _003CAddButtonClick_003Eb__1()
			{
			}
		}

		private static Dictionary<GObject, float> _btnLastClickTime;

		public static Vector2 GetLocalCenterXY(this GObject target)
		{
			return (Vector2)null;
		}

		public static void SetLocalCenterXY(this GObject target, Vector2 centerXY)
		{
		}

		public static float GetCenterX(GComponent node)
		{
			return 0f;
		}

		public static float GetToCenterX(GComponent node, float tx)
		{
			return 0f;
		}

		public static float GetCenterY(GComponent node)
		{
			return 0f;
		}

		public static float GetToCenterY(GComponent node, float ty)
		{
			return 0f;
		}

		public static float GetLeftX(GComponent node)
		{
			return 0f;
		}

		public static float GetRightX(GComponent node)
		{
			return 0f;
		}

		public static float GetToRightX(GComponent node, float tx)
		{
			return 0f;
		}

		public static float GetFromRightX(GComponent node, float tx)
		{
			return 0f;
		}

		public static float GetBottomY(GComponent node)
		{
			return 0f;
		}

		public static float GetToBottomY(GComponent node, float ty)
		{
			return 0f;
		}

		public static float GetFromBottomY(GComponent node, float ty)
		{
			return 0f;
		}

		public static float GetTopY(GComponent node)
		{
			return 0f;
		}

		public static void SetToCenter(GComponent node, GComponent target)
		{
		}

		public static void SetToCenter(GComponent node, float tx, float ty)
		{
		}

		public static void SetToCenterBottom(GComponent node, float tx, float ty)
		{
		}

		public static void SetToCenterTop(GComponent node, float tx, float ty)
		{
		}

		public static void SetToLeftBottom(GComponent node, float tx, float ty)
		{
		}

		public static void SetToLeftTop(GComponent node, float tx, float ty)
		{
		}

		public static void SetToLeft(GComponent node, float tx)
		{
		}

		public static void SetToRight(GComponent node, float tx)
		{
		}

		public static GComponent ApplyControllerPage(this GComponent target, string controllerName, string pageName)
		{
			return null;
		}

		public static bool IsControllerPage(this GComponent target, string controllerName, string pageName)
		{
			return false;
		}

		public static GObject AddChildWithURL(this GComponent target, string url, [Optional] Type userClass)
		{
			return null;
		}

		public static T AddChildWithURL<T>(this GComponent target, string url) where T : GObject
		{
			return null;
		}

		public static Vector2 ConvertToTargetXY(this GObject self, GObject target, float pivotX = 0.5f, float pivotY = 0.5f)
		{
			return (Vector2)null;
		}

		public static GButton AddButtonClick(this GButton btn, EventCallback0 callback, float clickInterval = 0f)
		{
			return null;
		}
	}
}
