using UnityEngine;

namespace Utils
{
	public interface SceneCallback
	{
		void OnSceneLoadFailed(string log);

		bool OnSceneLoadStart(AsyncOperation operation);

		bool OnSceneLoadEnd(AsyncOperation operation);
	}
}
