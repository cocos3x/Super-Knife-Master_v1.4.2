namespace FairyGUI
{
	public class DragDropManager
	{
		private GLoader _agent;

		private object _sourceData;

		private GObject _source;

		private static DragDropManager _inst;

		public static DragDropManager inst => null;

		public GLoader dragAgent => null;

		public bool dragging => false;

		public void StartDrag(GObject source, string icon, object sourceData, int touchPointID = -1)
		{
		}

		public void Cancel()
		{
		}

		private void __dragEnd(EventContext evt)
		{
		}
	}
}
