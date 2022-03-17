using System.Collections.Generic;
using UnityEngine;

public class SAudioManager : MonoBehaviour
{
	private class TweenItem
	{
		internal bool running;

		internal float startValue;

		internal float endValue;

		internal float curValue;

		internal float duration;

		internal float passTime;

		internal void Step(float dt)
		{
		}
	}

	private class LimitSoundItem
	{
		internal float passTime;

		internal int count;

		internal float duration;

		internal int limit;
	}

	private static string S_PREF_MUSIC_OPEN;

	private static string S_PREF_SOUND_OPEN;

	private static SAudioManager s_instance;

	private AudioSource _musicPlayer;

	private AudioSource _soundPlayer;

	private AudioSource _uiSoundPlayer;

	private AudioClip _currentMusicClip;

	private bool _isMusicOpen;

	private bool _isSoundOpen;

	private readonly TweenItem _musicPitchTween;

	private readonly Dictionary<string, LimitSoundItem> _limitSounds;

	private readonly Dictionary<string, LimitSoundItem> _uiLimitSounds;

	private bool _isMusicPlaying;

	private bool _isPause;

	private string _currentMusicName;

	public bool isMusicOpen
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool isSoundOpen
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static SAudioManager instance => null;

	public static string currentMusicName => "";

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public static void PlayMusic(string musicName)
	{
	}

	public static void PlayMusic(AudioClip musicClip)
	{
	}

	public static void StopMusic()
	{
	}

	private void DoPlayMusic(AudioClip musicClip)
	{
	}

	private void DoUpdateSound()
	{
	}

	private void DoStopMusic()
	{
	}

	public static void MusicPitchTo(float value, float duration)
	{
	}

	public static void PlaySoundLimit(AudioClip musicClip, string key, float duration, int limit)
	{
	}

	public static void PlaySoundLimit(AudioClip musicClip, float duration, int limit)
	{
	}

	public static void PlaySoundLimit(string name, float duration, int limit)
	{
	}

	public static void PlayUISoundLimit(AudioClip musicClip, string key, float duration, int limit)
	{
	}

	public static bool AllowPlaySoundLimit(string key)
	{
		return false;
	}

	public static bool AllowPlayUISoundLimit(string key)
	{
		return false;
	}

	public static bool AllowPlaySoundLimit(AudioClip musicClip)
	{
		return false;
	}

	public static bool AllowPlayUISoundLimit(AudioClip musicClip)
	{
		return false;
	}

	public static void PlayUISoundLimit(AudioClip musicClip, float duration, int limit)
	{
	}

	public static void PlayUISoundLimit(string name, float duration, int limit)
	{
	}

	private bool DoAllowPlayLimitSound(string key, bool isUISound = false)
	{
		return false;
	}

	private void DoPlaySoundLimit(AudioClip soundClip, string key, float duration, int limit, bool isUISound = false)
	{
	}

	public static void PlaySound(AudioClip soundClip)
	{
	}

	public static void PlaySound(string soundName)
	{
	}

	public static void PlayUISound(string soundName)
	{
	}

	public static void PlayUISound(AudioClip soundClip)
	{
	}

	private void DoPlaySound(AudioClip soundClip, bool isUISound = false)
	{
	}

	public static void PlayFairyUISound(string url)
	{
	}

	public static void Pause()
	{
	}

	public static void Resume()
	{
	}

	private void _003CStart_003Eb__26_0()
	{
	}
}
