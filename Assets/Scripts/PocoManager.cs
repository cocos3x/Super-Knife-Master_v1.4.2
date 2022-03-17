using Poco;
using System;
using System.Collections.Generic;
using TcpServer;
using UnityEngine;

public class PocoManager : MonoBehaviour
{
	private class RPC : Attribute
	{
	}

	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public TcpClientState internalClient;

		internal TcpClientState _003Cserver_Received_003Eb__0(string n, TcpClientState o)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public TcpClientState client;

		public PocoManager _003C_003E4__this;

		internal void _003CUpdate_003Eb__0(string msg)
		{
		}
	}

	public const int versionCode = 6;

	public int port;

	private bool mRunning;

	public AsyncTcpServer server;

	private RPCParser rpc;

	private SimpleProtocolFilter prot;

	private UnityDumper dumper;

	private ConcurrentDictionary<string, TcpClientState> inbox;

	private VRSupport vr_support;

	private Dictionary<string, long> debugProfilingData;

	private void Awake()
	{
	}

	private static void server_ClientConnected(object sender, TcpClientConnectedEventArgs e)
	{
	}

	private static void server_ClientDisconnected(object sender, TcpClientDisconnectedEventArgs e)
	{
	}

	private void server_Received(object sender, TcpDatagramReceivedEventArgs<byte[]> e)
	{
	}

	private object Dump(List<object> param)
	{
		return null;
	}

	private object Screenshot(List<object> param)
	{
		return null;
	}

	private object GetScreenSize(List<object> param)
	{
		return null;
	}

	public void stopListening()
	{
	}

	private object GetDebugProfilingData(List<object> param)
	{
		return null;
	}

	private object SetText(List<object> param)
	{
		return null;
	}

	private object GetSDKVersion(List<object> param)
	{
		return null;
	}

	private void Update()
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void OnDestroy()
	{
	}
}
