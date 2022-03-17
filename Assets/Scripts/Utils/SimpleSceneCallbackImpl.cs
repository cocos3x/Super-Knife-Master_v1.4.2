using System;
using UnityEngine;

namespace Utils
{
	public class SimpleSceneCallbackImpl : SceneCallback
	{
		public Action<AsyncOperation> sceneLoadStart;

		public Action<AsyncOperation> sceneLoadEnd;

		public void OnSceneLoadFailed(string log)
		{
		}

		public virtual bool OnSceneLoadStart(AsyncOperation operation)
		{
			return false;
		}

		public bool OnSceneLoadEnd(AsyncOperation operation)
		{
			return false;
		}
	}
}
