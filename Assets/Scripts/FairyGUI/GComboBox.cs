using FairyGUI.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace FairyGUI
{
	public class GComboBox : GComponent
	{
		public int visibleItemCount;

		public GComponent dropdown;

		public NAudioClip sound;

		public float soundVolumeScale;

		protected GObject _titleObject;

		protected GObject _iconObject;

		protected GList _list;

		protected List<string> _items;

		protected List<string> _icons;

		protected List<string> _values;

		protected PopupDirection _popupDirection;

		protected Controller _selectionController;

		private bool _itemsUpdated;

		private int _selectedIndex;

		private Controller _buttonController;

		private bool _down;

		private bool _over;

		private EventListener _onChanged;

		public EventListener onChanged => null;

		public override string icon
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public string title
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public override string text
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public Color titleColor
		{
			get
			{
				return (Color)null;
			}
			set
			{
			}
		}

		public int titleFontSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string[] items
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string[] icons
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string[] values
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<string> itemList => null;

		public List<string> valueList => null;

		public List<string> iconList => null;

		public int selectedIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Controller selectionController
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string value
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public PopupDirection popupDirection
		{
			get
			{
				//IL_0003: Expected I4, but got O
				return (PopupDirection)null;
			}
			set
			{
			}
		}

		public void ApplyListChange()
		{
		}

		public GTextField GetTextField()
		{
			return null;
		}

		protected void SetState(string value)
		{
		}

		protected void SetCurrentState()
		{
		}

		protected override void HandleGrayedChanged()
		{
		}

		public override void HandleControllerChanged(Controller c)
		{
		}

		private void UpdateSelectionController()
		{
		}

		public override void Dispose()
		{
		}

		protected override void ConstructExtension(ByteBuffer buffer)
		{
		}

		public override void Setup_AfterAdd(ByteBuffer buffer, int beginPos)
		{
		}

		public void UpdateDropdownList()
		{
		}

		protected void ShowDropdown()
		{
		}

		protected virtual void RenderDropdownList()
		{
		}

		private void __popupWinClosed(object obj)
		{
		}

		private void __clickItem(EventContext context)
		{
		}

		private void __rollover()
		{
		}

		private void __rollout()
		{
		}

		private void __touchBegin(EventContext context)
		{
		}

		private void __touchEnd(EventContext context)
		{
		}

		private void __click()
		{
		}
	}
}
