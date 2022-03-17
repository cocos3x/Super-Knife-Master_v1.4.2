using System.Collections.Generic;
using UnityEngine;

namespace FairyGUI
{
	public class GRoot : GComponent
	{
		private GGraph _modalLayer;

		private GObject _modalWaitPane;

		private List<GObject> _popupStack;

		private List<GObject> _justClosedPopups;

		private HashSet<GObject> _specialPopups;

		private GObject _tooltipWin;

		private GObject _defaultTooltipWin;

		internal static GRoot _inst;

		public static float contentScaleFactor => 0f;

		public static int contentScaleLevel => 0;

		public static GRoot inst => null;

		public GGraph modalLayer => null;

		public bool hasModalWindow => false;

		public bool modalWaiting => false;

		public GObject touchTarget => null;

		public bool hasAnyPopup => false;

		public GObject focus
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float soundVolume
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override void Dispose()
		{
		}

		public void SetContentScaleFactor(int designResolutionX, int designResolutionY)
		{
		}

		public void SetContentScaleFactor(int designResolutionX, int designResolutionY, UIContentScaler.ScreenMatchMode screenMatchMode)
		{
		}

		public void SetContentScaleFactor(float constantScaleFactor)
		{
		}

		public void ApplyContentScaleFactor()
		{
		}

		public void ShowWindow(Window win)
		{
		}

		public void HideWindow(Window win)
		{
		}

		public void HideWindowImmediately(Window win)
		{
		}

		public void HideWindowImmediately(Window win, bool dispose)
		{
		}

		public void BringToFront(Window win)
		{
		}

		public void ShowModalWait()
		{
		}

		public void CloseModalWait()
		{
		}

		public void CloseAllExceptModals()
		{
		}

		public void CloseAllWindows()
		{
		}

		public Window GetTopWindow()
		{
			return null;
		}

		private void CreateModalLayer()
		{
		}

		public GObject DisplayObjectToGObject(DisplayObject obj)
		{
			return null;
		}

		private void AdjustModalLayer()
		{
		}

		public void ShowPopup(GObject popup)
		{
		}

		public void ShowPopup(GObject popup, GObject target)
		{
		}

		public void ShowPopup(GObject popup, GObject target, object downward)
		{
		}

		public void ShowPopup(GObject popup, GObject target, PopupDirection dir)
		{
		}

		public void ShowPopup(GObject popup, GObject target, PopupDirection dir, bool closeUntilUpEvent)
		{
		}

		public Vector2 GetPoupPosition(GObject popup, GObject target, object downward)
		{
			return (Vector2)null;
		}

		public Vector2 GetPoupPosition(GObject popup, GObject target, PopupDirection dir)
		{
			return (Vector2)null;
		}

		public void TogglePopup(GObject popup)
		{
		}

		public void TogglePopup(GObject popup, GObject target)
		{
		}

		public void TogglePopup(GObject popup, GObject target, object downward)
		{
		}

		public void TogglePopup(GObject popup, GObject target, PopupDirection dir)
		{
		}

		public void TogglePopup(GObject popup, GObject target, PopupDirection dir, bool closeUntilUpEvent)
		{
		}

		public void HidePopup()
		{
		}

		public void HidePopup(GObject popup)
		{
		}

		private void ClosePopup(GObject target)
		{
		}

		public void ShowTooltips(string msg)
		{
		}

		public void ShowTooltips(string msg, float delay)
		{
		}

		public void ShowTooltipsWin(GObject tooltipWin)
		{
		}

		public void ShowTooltipsWin(GObject tooltipWin, float delay)
		{
		}

		private void __showTooltipsWin(object param)
		{
		}

		public void HideTooltips()
		{
		}

		private void __stageTouchBegin(EventContext context)
		{
		}

		private void __stageTouchEnd(EventContext context)
		{
		}

		private void CheckPopups(bool touchBegin)
		{
		}

		public void EnableSound()
		{
		}

		public void DisableSound()
		{
		}

		public void PlayOneShotSound(AudioClip clip, float volumeScale)
		{
		}

		public void PlayOneShotSound(AudioClip clip)
		{
		}
	}
}
