using Tool;

namespace Core
{
	public class BlockPool : SObjectPool<BlockPool, Block>
	{
		protected override Block NewObject(int poolId)
		{
			return null;
		}

		protected override void OnObjectAwake(Block obj)
		{
		}

		protected override void OnObjectSleep(Block obj)
		{
		}
	}
}
