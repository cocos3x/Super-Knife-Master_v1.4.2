namespace FairyGUI
{
	internal class TransitionItem
	{
		public float time;

		public string targetId;

		public TransitionActionType type;

		public TweenConfig tweenConfig;

		public string label;

		public object value;

		public TransitionHook hook;

		public GTweener tweener;

		public GObject target;

		public uint displayLockToken;

		public TransitionItem(TransitionActionType type)
		{
		}
	}
}
