using FairyGUI;
using System.Collections.Generic;

namespace Master
{
	public class SNameTree
	{
		private GObject _owner;

		private Dictionary<string, SNameTree> _children;

		public GObject owner
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SNameTree this[string name] => null;

		public GObject asObject => null;

		public GImage asImage => null;

		public GComponent asCom => null;

		public GButton asButton => null;

		public GLabel asLabel => null;

		public GProgressBar asProgress => null;

		public GSlider asSlider => null;

		public GComboBox asComboBox => null;

		public GTextField asTextField => null;

		public GRichTextField asRichTextField => null;

		public GTextInput asTextInput => null;

		public GLoader asLoader => null;

		public GLoader3D asLoader3D => null;

		public GList asList => null;

		public GGraph asGraph => null;

		public GGroup asGroup => null;

		public GMovieClip asMovieClip => null;

		public GTree asTree => null;

		public GTreeNode treeNode => null;

		public string text
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public bool visible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool touchable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool grayed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string icon
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public SNameTree(GObject owner)
		{
		}

		public void RunTween(tw.TWAction tween)
		{
		}

		public void RunTweenX(tw.TWAction tween)
		{
		}

		public void StopAllTween()
		{
		}
	}
}
