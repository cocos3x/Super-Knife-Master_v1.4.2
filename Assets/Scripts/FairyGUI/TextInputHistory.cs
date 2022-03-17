using System.Collections.Generic;

namespace FairyGUI
{
	internal class TextInputHistory
	{
		private static TextInputHistory _inst;

		private List<string> _undoBuffer;

		private List<string> _redoBuffer;

		private string _currentText;

		private InputTextField _textField;

		private bool _lock;

		private int _changedFrame;

		public const int maxHistoryLength = 5;

		public static TextInputHistory inst => null;

		public void StartRecord(InputTextField textField)
		{
		}

		public void MarkChanged(InputTextField textField)
		{
		}

		public void StopRecord(InputTextField textField)
		{
		}

		public void Undo(InputTextField textField)
		{
		}

		public void Redo(InputTextField textField)
		{
		}
	}
}
