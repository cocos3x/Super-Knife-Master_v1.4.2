using FairyGUI.Utils;

namespace FairyGUI
{
	public abstract class GearBase
	{
		public static bool disableAllTweenEffect;

		protected GObject _owner;

		protected Controller _controller;

		protected GearTweenConfig _tweenConfig;

		public Controller controller
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GearTweenConfig tweenConfig => null;

		public GearBase(GObject owner)
		{
		}

		public void Dispose()
		{
		}

		public void Setup(ByteBuffer buffer)
		{
		}

		public virtual void UpdateFromRelations(float dx, float dy)
		{
		}

		protected abstract void AddStatus(string pageId, ByteBuffer buffer);

		protected abstract void Init();

		public abstract void Apply();

		public abstract void UpdateState();
	}
}
