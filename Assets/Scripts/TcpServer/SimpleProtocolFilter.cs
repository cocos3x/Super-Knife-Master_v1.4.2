using System.Collections.Generic;

namespace TcpServer
{
	public class SimpleProtocolFilter : ProtoFilter
	{
		private byte[] buf;

		private int HEADER_SIZE;

		private List<string> msgs;

		public void input(byte[] data)
		{
		}

		public List<string> swap_msgs()
		{
			return null;
		}

		public byte[] pack(string content)
		{
			return null;
		}

		private static byte[] Combine(byte[] first, byte[] second)
		{
			return null;
		}

		public byte[] Slice(byte[] source, int start, int end)
		{
			return null;
		}
	}
}
