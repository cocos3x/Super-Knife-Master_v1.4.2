using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class RPCParser
{
	public delegate object RpcMethod(List<object> param);

	protected Dictionary<string, RpcMethod> RPCHandler;

	private JsonSerializerSettings settings;

	public string HandleMessage(string json)
	{
		return "";
	}

	public string formatRequest(string method, object idAction, [Optional] List<object> param)
	{
		return "";
	}

	public string formatResponse(object idAction, object result)
	{
		return "";
	}

	public string formatResponseError(object idAction, IDictionary<string, object> data, Exception e)
	{
		return "";
	}

	public void addRpcMethod(string name, RpcMethod method)
	{
	}
}
