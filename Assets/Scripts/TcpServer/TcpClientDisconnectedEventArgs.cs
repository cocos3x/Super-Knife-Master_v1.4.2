using System;
using System.Net.Sockets;

namespace TcpServer
{
	public class TcpClientDisconnectedEventArgs : EventArgs
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

		public TcpClientDisconnectedEventArgs(TcpClient tcpClient)
		{
		}
	}
}
