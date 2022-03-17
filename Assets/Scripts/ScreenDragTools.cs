using DG.Tweening;
using FairyGUI;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

public class ScreenDragTools
{
	public class Builder
	{
		private string savePositionKey;

		public ScreenDragTools Drag(GComponent obj, [Optional] GComponent dragRoot, [Optional] Action onUpdateParent)
		{
			return null;
		}

		public Builder SaveKey(string key)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public ScreenDragTools tools;

		public GComponent root;

		public Action onUpdateParent;

		internal void _003Cinit_003Eg__updateParent_007C0()
		{
		}
	}

	private GComponent _dragObj;

	private Tween _sideTween;

	private int __touchId;

	private bool _isDragging;

	private Vector2 _touchDownOffset;

	private Vector2 _saveGlobalPosition;

	private float SIDE_OFF_SET;

	private const string SAVE_KEY_FIX = "ScreenDrag_";

	private string positionKey;

	private string X => "";

	private string Y => "";

	private string INI_X => "";

	private string INI_Y => "";

	private ScreenDragTools()
	{
	}

	public static Builder GetBuilder()
	{
		return null;
	}

	private static ScreenDragTools Drag(GComponent obj, [Optional] GComponent root, [Optional] string savePositionKey, [Optional] Action onUpdateParent)
	{
		return null;
	}

	private static void init(ScreenDragTools tools, GComponent obj, GComponent root, [Optional] string savePositionKey, [Optional] Action onUpdateParent)
	{
	}

	private void OnDragBegin(EventContext context)
	{
	}

	private void OnDragEnd(EventContext context)
	{
	}

	private void OnDragMove(EventContext context)
	{
	}

	private void HoldSide()
	{
	}

	private Vector2 VerifyPosition(Vector2 old)
	{
		return (Vector2)null;
	}

	private void SavePosition()
	{
	}

	public void ResetPosition()
	{
	}
}
