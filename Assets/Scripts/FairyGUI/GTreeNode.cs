using System.Collections.Generic;

namespace FairyGUI
{
	public class GTreeNode
	{
		public object data;

		private GTreeNode _003Cparent_003Ek__BackingField;

		private GTree _003Ctree_003Ek__BackingField;

		private List<GTreeNode> _children;

		private bool _expanded;

		private int _level;

		internal GComponent _cell;

		internal string _resURL;

		public GTreeNode parent
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public GTree tree
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public GComponent cell => null;

		public int level => 0;

		public bool expanded
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isFolder => false;

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

		public int numChildren => 0;

		public GTreeNode(bool hasChild)
		{
		}

		public GTreeNode(bool hasChild, string resURL)
		{
		}

		public void ExpandToRoot()
		{
		}

		public GTreeNode AddChild(GTreeNode child)
		{
			return null;
		}

		public GTreeNode AddChildAt(GTreeNode child, int index)
		{
			return null;
		}

		public GTreeNode RemoveChild(GTreeNode child)
		{
			return null;
		}

		public GTreeNode RemoveChildAt(int index)
		{
			return null;
		}

		public void RemoveChildren(int beginIndex = 0, int endIndex = -1)
		{
		}

		public GTreeNode GetChildAt(int index)
		{
			return null;
		}

		public int GetChildIndex(GTreeNode child)
		{
			return 0;
		}

		public GTreeNode GetPrevSibling()
		{
			return null;
		}

		public GTreeNode GetNextSibling()
		{
			return null;
		}

		public void SetChildIndex(GTreeNode child, int index)
		{
		}

		public void SwapChildren(GTreeNode child1, GTreeNode child2)
		{
		}

		public void SwapChildrenAt(int index1, int index2)
		{
		}

		internal void _SetTree(GTree value)
		{
		}
	}
}
