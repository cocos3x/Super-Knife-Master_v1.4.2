using FairyGUI.Utils;

namespace FairyGUI
{
	public class ControllerAction
	{
		public enum ActionType
		{
			PlayTransition,
			ChangePage
		}

		public string[] fromPage;

		public string[] toPage;

		public static ControllerAction CreateAction(ActionType type)
		{
			return null;
		}

		public void Run(Controller controller, string prevPage, string curPage)
		{
		}

		protected virtual void Enter(Controller controller)
		{
		}

		protected virtual void Leave(Controller controller)
		{
		}

		public virtual void Setup(ByteBuffer buffer)
		{
		}
	}
}
