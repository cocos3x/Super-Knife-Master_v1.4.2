using System.Collections.Generic;

namespace Poco
{
	public class AbstractNode
	{
		private List<string> requiredAttrs;

		public virtual AbstractNode getParent()
		{
			return null;
		}

		public virtual List<AbstractNode> getChildren()
		{
			return null;
		}

		public virtual object getAttr(string attrName)
		{
			return null;
		}

		public virtual void setAttr(string attrName, object val)
		{
		}

		public virtual Dictionary<string, object> enumerateAttrs()
		{
			return null;
		}
	}
}
