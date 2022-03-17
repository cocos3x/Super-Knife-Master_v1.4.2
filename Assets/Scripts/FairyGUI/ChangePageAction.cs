using FairyGUI.Utils;

namespace FairyGUI
{
	public class ChangePageAction : ControllerAction
	{
		public string objectId;

		public string controllerName;

		public string targetPage;

		protected override void Enter(Controller controller)
		{
		}

		public override void Setup(ByteBuffer buffer)
		{
		}
	}
}
