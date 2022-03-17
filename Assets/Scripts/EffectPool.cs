using System.Collections.Generic;
using Tool;

public class EffectPool : SObjectPool<EffectPool, GEffectNode>
{
	private sealed class _003C_003Ec__DisplayClass1_0
	{
		public EffectPool _003C_003E4__this;

		public GEffectNode node;

		internal void _003CGetEffectNode_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public GEffectNode node;

		public EffectPool _003C_003E4__this;

		internal void _003CNewObject_003Eb__0()
		{
		}
	}

	private List<string> _urls;

	public GEffectNode GetEffectNode(string url)
	{
		return null;
	}

	public void ReturnObject(GEffectNode node)
	{
	}

	public void LoadObject(string url, int count)
	{
	}

	protected override GEffectNode NewObject(int poolId)
	{
		return null;
	}

	private string GetEffectUrl(int poolId)
	{
		return "";
	}

	private int GetEffectPoolId(string url)
	{
		return 0;
	}

	protected override void OnObjectAwake(GEffectNode node)
	{
	}

	protected override void OnObjectSleep(GEffectNode node)
	{
	}
}
