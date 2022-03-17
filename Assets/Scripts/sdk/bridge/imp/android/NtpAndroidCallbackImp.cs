using sdk.bridge.interf;
using System;
using UnityEngine;

namespace sdk.bridge.imp.android
{
	public class NtpAndroidCallbackImp : AndroidJavaProxy, INtpCallback
	{
		private Action _action;

		public static NtpAndroidCallbackImp Create(Action action, string javaInterface)
		{
			return null;
		}

		public NtpAndroidCallbackImp(string javaInterface)
		{
		}

		public void OnNtpGet()
		{
		}
	}
}
