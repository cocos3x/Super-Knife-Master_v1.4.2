using System.Collections.Generic;

namespace FairyGUI
{
	public class TreeView : EventDispatcher
	{
		public delegate GComponent TreeNodeCreateCellDelegate(TreeNode node);

		public delegate void TreeNodeRenderDelegate(TreeNode node);

		public delegate void TreeNodeWillExpandDelegate(TreeNode node, bool expand);

		private GList _003Clist_003Ek__BackingField;

		private TreeNode _003Croot_003Ek__BackingField;

		public int indent;

		public TreeNodeCreateCellDelegate treeNodeCreateCell;

		public TreeNodeRenderDelegate treeNodeRender;

		public TreeNodeWillExpandDelegate treeNodeWillExpand;

		private EventListener _003ConClickNode_003Ek__BackingField;

		private EventListener _003ConRightClickNode_003Ek__BackingField;

		public GList list
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public TreeNode root
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public EventListener onClickNode
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public EventListener onRightClickNode
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public TreeView(GList list)
		{
		}

		public TreeNode GetSelectedNode()
		{
			return null;
		}

		public List<TreeNode> GetSelection()
		{
			return null;
		}

		public void AddSelection(TreeNode node, bool scrollItToView = false)
		{
		}

		public void RemoveSelection(TreeNode node)
		{
		}

		public void ClearSelection()
		{
		}

		public int GetNodeIndex(TreeNode node)
		{
			return 0;
		}

		public void UpdateNode(TreeNode node)
		{
		}

		public void UpdateNodes(List<TreeNode> nodes)
		{
		}

		public void ExpandAll(TreeNode folderNode)
		{
		}

		public void CollapseAll(TreeNode folderNode)
		{
		}

		private void CreateCell(TreeNode node)
		{
		}

		internal void AfterInserted(TreeNode node)
		{
		}

		private int GetInsertIndexForNode(TreeNode node)
		{
			return 0;
		}

		internal void AfterRemoved(TreeNode node)
		{
		}

		internal void AfterExpanded(TreeNode node)
		{
		}

		internal void AfterCollapsed(TreeNode node)
		{
		}

		internal void AfterMoved(TreeNode node)
		{
		}

		private int CheckChildren(TreeNode folderNode, int index)
		{
			return 0;
		}

		private void HideFolderNode(TreeNode folderNode)
		{
		}

		private void RemoveNode(TreeNode node)
		{
		}

		private void __clickExpandButton(EventContext context)
		{
		}

		private void __clickItem(EventContext context)
		{
		}
	}
}
