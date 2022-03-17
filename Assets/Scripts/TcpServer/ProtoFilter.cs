using System.Collections.Generic;

namespace TcpServer
{
	public interface ProtoFilter
	{
		void input(byte[] data);

		List<string> swap_msgs();
	}
}
