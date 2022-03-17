using System;
using System.Collections.Generic;
using UnityEngine;

namespace FairyGUI
{
	public class UIPanel : MonoBehaviour, EMRenderTarget
	{
		private Container _003Ccontainer_003Ek__BackingField;

		public string packageName;

		public string componentName;

		public FitScreen fitScreen;

		public int sortingOrder;

		[SerializeField]
		private string packagePath;

		[SerializeField]
		private RenderMode renderMode;

		[SerializeField]
		private Camera renderCamera;

		[SerializeField]
		private Vector3 position;

		[SerializeField]
		private Vector3 scale;

		[SerializeField]
		private Vector3 rotation;

		[SerializeField]
		private bool fairyBatching;

		[SerializeField]
		private bool touchDisabled;

		[SerializeField]
		private Vector2 cachedUISize;

		[SerializeField]
		private HitTestMode hitTestMode;

		[SerializeField]
		private bool setNativeChildrenOrder;

		[NonSerialized]
		private int screenSizeVer;

		[NonSerialized]
		private Rect uiBounds;

		private GComponent _ui;

		[NonSerialized]
		private bool _created;

		private List<Renderer> _renders;

		public Container container
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public GComponent ui => null;

		public int EM_sortingOrder => 0;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}

		private void CreateContainer()
		{
		}

		public void CreateUI()
		{
		}

		public void SetSortingOrder(int value, bool apply)
		{
		}

		public void SetHitTestMode(HitTestMode value)
		{
		}

		public void CacheNativeChildrenRenderers()
		{
		}

		private void CreateUI_PlayMode()
		{
		}

		private void UpdateHitArea()
		{
		}

		private void CreateUI_EditMode()
		{
		}

		private void HandleScreenSizeChanged()
		{
		}

		private void OnUpdateSource(object[] data)
		{
		}

		public void ApplyModifiedProperties(bool sortingOrderChanged, bool fitScreenChanged)
		{
		}

		public void MoveUI(Vector3 delta)
		{
		}

		public Vector3 GetUIWorldPosition()
		{
			return (Vector3)null;
		}

		private void OnDrawGizmos()
		{
		}

		public void EM_BeforeUpdate()
		{
		}

		public void EM_Update(UpdateContext context)
		{
		}

		public void EM_Reload()
		{
		}

		private void _003CCreateContainer_003Eb__29_0()
		{
		}
	}
}
