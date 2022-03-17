using FairyGUI.Utils;

namespace FairyGUI
{
	public class PlayTransitionAction : ControllerAction
	{
		public string transitionName;

		public int playTimes;

		public float delay;

		public bool stopOnExit;

		private Transition _currentTransition;

		protected override void Enter(Controller controller)
		{
		}

		protected override void Leave(Controller controller)
		{
		}

		public override void Setup(ByteBuffer buffer)
		{
		}
	}
}
