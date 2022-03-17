using System.Collections.Generic;

namespace Poco
{
	public interface IDumper
	{
		AbstractNode getRoot();

		Dictionary<string, object> dumpHierarchy();

		Dictionary<string, object> dumpHierarchy(bool onlyVisibleNode);

		List<float> getPortSize();
	}
}
