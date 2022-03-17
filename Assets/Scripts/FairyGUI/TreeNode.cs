using System.Collections.Generic;

namespace FairyGUI
{
	public class TreeNode
	{
		public object data;

		private TreeNode _003Cparent_003Ek__BackingField;

		private TreeView _003Ctree_003Ek__BackingField;

		private GComponent _003Ccell_003Ek__BackingField;

		private int _003Clevel_003Ek__BackingField;

		private List<TreeNode> _children;

		private bool _expanded;

		public TreeNode parent
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public TreeView tree
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public GComponent cell
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public int level
		{
			get
			{
				return 0;
			}
			private set
			{
			}
		}

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

		public string text => "";

		public int numChildren => 0;

		public TreeNode(bool hasChild)
		{
		}

		public TreeNode AddChild(TreeNode child)
		{
			return null;
		}

		public TreeNode AddChildAt(TreeNode child, int index)
		{
			return null;
		}

		public TreeNode RemoveChild(TreeNode child)
		{
			return null;
		}

		public TreeNode RemoveChildAt(int index)
		{
			return null;
		}

		public void RemoveChildren(int beginIndex = 0, int endIndex = -1)
		{
		}

		public TreeNode GetChildAt(int index)
		{
			return null;
		}

		public int GetChildIndex(TreeNode child)
		{
			return 0;
		}

		public TreeNode GetPrevSibling()
		{
			return null;
		}

		public TreeNode GetNextSibling()
		{
			return null;
		}

		public void SetChildIndex(TreeNode child, int index)
		{
		}

		public void SwapChildren(TreeNode child1, TreeNode child2)
		{
		}

		public void SwapChildrenAt(int index1, int index2)
		{
		}

		internal void SetTree(TreeView value)
		{
		}
	}
}
