using System;
using UnityEngine;

namespace FairyGUI
{
	public class NAudioClip
	{
		public static Action<AudioClip> CustomDestroyMethod;

		public DestroyMethod destroyMethod;

		public AudioClip nativeClip;

		public NAudioClip(AudioClip audioClip)
		{
		}

		public void Unload()
		{
		}

		public void Reload(AudioClip audioClip)
		{
		}
	}
}
