using System;
using System.Net.Sockets;

namespace TcpServer
{
	public class TcpDatagramReceivedEventArgs<T> : EventArgs
	{
		private TcpClientState _003CClient_003Ek__BackingField;

		private TcpClient _003CTcpClient_003Ek__BackingField;

		private T _003CDatagram_003Ek__BackingField;

		public TcpClientState Client
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

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

		public T Datagram
		{
			get
			{
				return (T)null;
			}
			private set
			{
			}
		}

		public TcpDatagramReceivedEventArgs(TcpClientState tcpClientState, T datagram)
		{
		}
	}
}
