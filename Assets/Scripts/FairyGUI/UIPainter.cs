using System;
using UnityEngine;

namespace FairyGUI
{
	public class UIPainter : MonoBehaviour, EMRenderTarget
	{
		private Container _003Ccontainer_003Ek__BackingField;

		public string packageName;

		public string componentName;

		public int sortingOrder;

		[SerializeField]
		private string packagePath;

		[SerializeField]
		private Camera renderCamera;

		[SerializeField]
		private bool fairyBatching;

		[SerializeField]
		private bool touchDisabled;

		private GComponent _ui;

		[NonSerialized]
		private bool _created;

		[NonSerialized]
		private bool _captured;

		[NonSerialized]
		private Renderer _renderer;

		[NonSerialized]
		private RenderTexture _texture;

		private Action _captureDelegate;

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

		private void OnGUI()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void CreateContainer()
		{
		}

		public void SetSortingOrder(int value, bool apply)
		{
		}

		public void CreateUI()
		{
		}

		private void Capture()
		{
		}

		private void DestroyTexture()
		{
		}

		private void CaptureInEditMode()
		{
		}

		public void ApplyModifiedProperties(bool sortingOrderChanged)
		{
		}

		public void OnUpdateSource(object[] data)
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

		private void _003CCreateUI_003Eb__26_0()
		{
		}
	}
}
