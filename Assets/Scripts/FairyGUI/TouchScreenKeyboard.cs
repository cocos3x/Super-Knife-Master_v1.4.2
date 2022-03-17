using UnityEngine;

namespace FairyGUI
{
	public class TouchScreenKeyboard : IKeyboard
	{
		private UnityEngine.TouchScreenKeyboard _keyboard;

		public bool done => false;

		public bool supportsCaret => false;

		public string GetInput()
		{
			return "";
		}

		public void Open(string text, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int keyboardType, bool hideInput)
		{
		}

		public void Close()
		{
		}
	}
}
