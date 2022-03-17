using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TcpServer
{
	public class AsyncTcpServer : IDisposable
	{
		private sealed class _003C_003Ec__DisplayClass26_0
		{
			public TcpClientState internalClient;

			internal TcpClientState _003CHandleTcpClientAccepted_003Eb__0(string n, TcpClientState o)
			{
				return null;
			}
		}

		private TcpListener _listener;

		private ConcurrentDictionary<string, TcpClientState> _clients;

		private bool _disposed;

		private bool _003CIsRunning_003Ek__BackingField;

		private IPAddress _003CAddress_003Ek__BackingField;

		private int _003CPort_003Ek__BackingField;

		private Encoding _003CEncoding_003Ek__BackingField;

		public bool IsRunning
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		public IPAddress Address
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public int Port
		{
			get
			{
				return 0;
			}
			private set
			{
			}
		}

		public Encoding Encoding
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public event EventHandler<TcpDatagramReceivedEventArgs<byte[]>> DatagramReceived
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler<TcpDatagramReceivedEventArgs<string>> PlaintextReceived
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler<TcpClientConnectedEventArgs> ClientConnected
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler<TcpClientDisconnectedEventArgs> ClientDisconnected
		{
			add
			{
			}
			remove
			{
			}
		}

		public AsyncTcpServer(int listenPort)
		{
		}

		public AsyncTcpServer(IPEndPoint localEP)
		{
		}

		public AsyncTcpServer(IPAddress localIPAddress, int listenPort)
		{
		}

		public AsyncTcpServer Start()
		{
			return null;
		}

		public AsyncTcpServer Start(int backlog)
		{
			return null;
		}

		public AsyncTcpServer Stop()
		{
			return null;
		}

		private void ContinueAcceptTcpClient(TcpListener tcpListener)
		{
		}

		private void HandleTcpClientAccepted(IAsyncResult ar)
		{
		}

		private void HandleDatagramReceived(IAsyncResult ar)
		{
		}

		private void ContinueReadBuffer(TcpClientState internalClient, NetworkStream networkStream)
		{
		}

		private void RaiseDatagramReceived(TcpClientState sender, byte[] datagram)
		{
		}

		private void RaisePlaintextReceived(TcpClientState sender, byte[] datagram)
		{
		}

		private void RaiseClientConnected(TcpClient tcpClient)
		{
		}

		private void RaiseClientDisconnected(TcpClient tcpClient)
		{
		}

		private void GuardRunning()
		{
		}

		public void Send(TcpClient tcpClient, byte[] datagram)
		{
		}

		public void Send(TcpClient tcpClient, string datagram)
		{
		}

		public void SendToAll(byte[] datagram)
		{
		}

		public void SendToAll(string datagram)
		{
		}

		private void HandleDatagramWritten(IAsyncResult ar)
		{
		}

		public void SyncSend(TcpClient tcpClient, byte[] datagram)
		{
		}

		public void SyncSend(TcpClient tcpClient, string datagram)
		{
		}

		public void SyncSendToAll(byte[] datagram)
		{
		}

		public void SyncSendToAll(string datagram)
		{
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}
	}
}
