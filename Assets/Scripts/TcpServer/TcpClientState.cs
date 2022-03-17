using System.Net.Sockets;

namespace TcpServer
{
	public class TcpClientState
	{
		private TcpClient _003CTcpClient_003Ek__BackingField;

		private byte[] _003CBuffer_003Ek__BackingField;

		private ProtoFilter _003CProt_003Ek__BackingField;

		public TcpClient TcpClient
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public byte[] Buffer
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public ProtoFilter Prot
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public NetworkStream NetworkStream => null;

		public TcpClientState(TcpClient tcpClient, byte[] buffer, ProtoFilter prot)
		{
		}
	}
}
