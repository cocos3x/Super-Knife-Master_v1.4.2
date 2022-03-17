using System.Collections.Generic;
using UnityEngine;

public class SVibrationManager : MonoBehaviour
{
	private class LimitVibrateItem
	{
		internal float passTime;

		internal int count;

		internal float duration;

		internal int limit;
	}

	private static string S_PREF_VIBRATION_OPEN;

	private static SVibrationManager s_instance;

	private bool _isVibrationOpen;

	private readonly Dictionary<string, LimitVibrateItem> _limits;

	public static SVibrationManager instance => null;

	public bool isVibrationOpen
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void DoUpdateVibration()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public static void ShortVibrate()
	{
	}

	public static void LongVibrate()
	{
	}

	public static void ShortVibrateLimit(string key, float duration, int limit = 1)
	{
	}

	private void DoShortVibrateLimit(string key, float duration, int limit)
	{
	}
}
