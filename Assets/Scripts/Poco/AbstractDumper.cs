using System.Collections.Generic;

namespace Poco
{
	public class AbstractDumper : IDumper
	{
		public virtual AbstractNode getRoot()
		{
			return null;
		}

		public Dictionary<string, object> dumpHierarchy()
		{
			return null;
		}

		public Dictionary<string, object> dumpHierarchy(bool onlyVisibleNode)
		{
			return null;
		}

		private Dictionary<string, object> dumpHierarchyImpl(AbstractNode node, bool onlyVisibleNode)
		{
			return null;
		}

		public virtual List<float> getPortSize()
		{
			return null;
		}
	}
}
