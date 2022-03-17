using System;
using System.Net.Sockets;

namespace TcpServer
{
	public class TcpClientConnectedEventArgs : EventArgs
	{
		private TcpClient _003CTcpClient_003Ek__BackingField;

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

		public TcpClientConnectedEventArgs(TcpClient tcpClient)
		{
		}
	}
}
