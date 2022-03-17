using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace FairyGUI
{
	public class Stage : Container
	{
		private class CursorDef
		{
			public Texture2D texture;

			public Vector2 hotspot;
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Comparison<DisplayObject> _003C_003E9__111_0;

			internal int _003CSortWorldSpacePanelsByZOrder_003Eb__111_0(DisplayObject c1, DisplayObject c2)
			{
				return 0;
			}
		}

		private float _003CsoundVolume_003Ek__BackingField;

		private DisplayObject _touchTarget;

		private DisplayObject _focused;

		private InputTextField _lastInput;

		private bool _IMEComposite;

		private UpdateContext _updateContext;

		private List<DisplayObject> _rollOutChain;

		private List<DisplayObject> _rollOverChain;

		private TouchInfo[] _touches;

		private int _touchCount;

		private Vector2 _touchPosition;

		private int _frameGotHitTarget;

		private int _frameGotTouchPosition;

		private bool _customInput;

		private Vector2 _customInputPos;

		private bool _customInputButtonDown;

		private AudioSource _audio;

		private List<NTexture> _toCollectTextures;

		private EventListener _onStageResized;

		private List<DisplayObject> _focusOutChain;

		private List<DisplayObject> _focusInChain;

		private List<Container> _focusHistory;

		private Container _nextFocus;

		private Dictionary<string, CursorDef> _cursors;

		private string _currentCursor;

		private static bool _touchScreen;

		internal static int _clickTestThreshold;

		private static IKeyboard _keyboard;

		private static Stage _inst;

		private static bool _003CkeyboardInput_003Ek__BackingField;

		private static float _003CdevicePixelRatio_003Ek__BackingField;

		private static List<DisplayObject> sTempList1;

		private static List<int> sTempList2;

		private static Dictionary<uint, int> sTempDict;

		public int stageHeight => 0;

		public int stageWidth => 0;

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

		public static Stage inst => null;

		public static bool touchScreen
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool keyboardInput
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool isTouchOnUI => false;

		public static float devicePixelRatio
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public EventListener onStageResized => null;

		public DisplayObject touchTarget => null;

		public DisplayObject focus
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector2 touchPosition => (Vector2)null;

		public int touchCount => 0;

		public IKeyboard keyboard
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string activeCursor => "";

		public event Action beforeUpdate
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action afterUpdate
		{
			add
			{
			}
			remove
			{
			}
		}

		public static void Instantiate()
		{
		}

		private void SceneManager_sceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		public override void Dispose()
		{
		}

		public void SetFocus(DisplayObject newFocus, bool byKey = false)
		{
		}

		internal void _OnFocusRemoving(Container sender)
		{
		}

		public void DoKeyNavigate(bool backward)
		{
		}

		public Vector2 GetTouchPosition(int touchId)
		{
			return (Vector2)null;
		}

		public DisplayObject GetTouchTarget(int touchId)
		{
			return null;
		}

		public int[] GetAllTouch(int[] result)
		{
			return null;
		}

		public void ResetInputState()
		{
		}

		public void CancelClick(int touchId)
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

		public void OpenKeyboard(string text, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int keyboardType, bool hideInput)
		{
		}

		public void CloseKeyboard()
		{
		}

		public void InputString(string value)
		{
		}

		public void SetCustomInput(Vector2 screenPos, bool buttonDown)
		{
		}

		public void SetCustomInput(Vector2 screenPos, bool buttonDown, bool buttonUp)
		{
		}

		public void SetCustomInput(ref RaycastHit hit, bool buttonDown)
		{
		}

		public void SetCustomInput(ref RaycastHit hit, bool buttonDown, bool buttonUp)
		{
		}

		public void ForceUpdate()
		{
		}

		internal void InternalUpdate()
		{
		}

		private void GetHitTarget()
		{
		}

		internal void HandleScreenSizeChanged(int screenWidth, int screenHeight, float unitsPerPixel)
		{
		}

		internal void HandleGUIEvents(Event evt)
		{
		}

		private void HandleEvents()
		{
		}

		private void UpdateTouchPosition()
		{
		}

		private void HandleTextInput()
		{
		}

		private void HandleCustomInput()
		{
		}

		private void HandleMouseEvents()
		{
		}

		private void HandleTouchEvents()
		{
		}

		private void HandleRollOver(TouchInfo touch)
		{
		}

		public void ApplyPanelOrder(Container target)
		{
		}

		public void SortWorldSpacePanelsByZOrder(int panelSortingOrder)
		{
		}

		public void MonitorTexture(NTexture texture)
		{
		}

		private void RunTextureCollector(object param)
		{
		}

		public void AddTouchMonitor(int touchId, EventDispatcher target)
		{
		}

		public void RemoveTouchMonitor(EventDispatcher target)
		{
		}

		public bool IsTouchMonitoring(EventDispatcher target)
		{
			return false;
		}

		internal Transform CreatePoolManager(string name)
		{
			return null;
		}

		public void RegisterCursor(string cursorName, Texture2D texture, Vector2 hotspot)
		{
		}

		internal void _ChangeCursor(string cursorName)
		{
		}
	}
}
