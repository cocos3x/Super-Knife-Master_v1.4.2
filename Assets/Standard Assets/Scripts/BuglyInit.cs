using System.Collections.Generic;
using UnityEngine;

public class BuglyInit : MonoBehaviour
{
	private const string BuglyAppID = "YOUR APP ID GOES HERE";

	private void Awake()
	{
	}

	private static Dictionary<string, string> MyLogCallbackExtrasHandler()
	{
		return null;
	}
}
