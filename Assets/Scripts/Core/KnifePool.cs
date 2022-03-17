using Tool;

namespace Core
{
	public class KnifePool : SObjectPool<KnifePool, Knife>
	{
		protected override Knife NewObject(int poolId)
		{
			return null;
		}

		protected override void OnObjectAwake(Knife obj)
		{
		}

		protected override void OnObjectSleep(Knife obj)
		{
		}
	}
}
