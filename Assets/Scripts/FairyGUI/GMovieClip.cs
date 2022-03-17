using FairyGUI.Utils;
using UnityEngine;

namespace FairyGUI
{
	public class GMovieClip : GObject, IAnimationGear, IColorGear
	{
		private MovieClip _content;

		private EventListener _onPlayEnd;

		public EventListener onPlayEnd => null;

		public bool playing
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int frame
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Color color
		{
			get
			{
				return (Color)null;
			}
			set
			{
			}
		}

		public FlipType flip
		{
			get
			{
				//IL_0003: Expected I4, but got O
				return (FlipType)null;
			}
			set
			{
			}
		}

		public Material material
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string shader
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public float timeScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool ignoreEngineTimeScale
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected override void CreateDisplayObject()
		{
		}

		public void Rewind()
		{
		}

		public void SyncStatus(GMovieClip anotherMc)
		{
		}

		public void Advance(float time)
		{
		}

		public void SetPlaySettings(int start, int end, int times, int endAt)
		{
		}

		public override void ConstructFromResource()
		{
		}

		public override void Setup_BeforeAdd(ByteBuffer buffer, int beginPos)
		{
		}
	}
}
