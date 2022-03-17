using System.Collections.Generic;

namespace Poco
{
	public class RootNode : AbstractNode
	{
		private List<AbstractNode> children;

		public override List<AbstractNode> getChildren()
		{
			return null;
		}
	}
}
