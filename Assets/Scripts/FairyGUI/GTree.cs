using FairyGUI.Utils;
using System.Collections.Generic;

namespace FairyGUI
{
	public class GTree : GList
	{
		public delegate void TreeNodeRenderDelegate(GTreeNode node, GComponent obj);

		public delegate void TreeNodeWillExpandDelegate(GTreeNode node, bool expand);

		public TreeNodeRenderDelegate treeNodeRender;

		public TreeNodeWillExpandDelegate treeNodeWillExpand;

		private int _indent;

		private GTreeNode _rootNode;

		private int _clickToExpand;

		private bool _expandedStatusInEvt;

		private static List<int> helperIntList;

		public GTreeNode rootNode => null;

		public int indent
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int clickToExpand
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public GTreeNode GetSelectedNode()
		{
			return null;
		}

		public List<GTreeNode> GetSelectedNodes()
		{
			return null;
		}

		public List<GTreeNode> GetSelectedNodes(List<GTreeNode> result)
		{
			return null;
		}

		public void SelectNode(GTreeNode node)
		{
		}

		public void SelectNode(GTreeNode node, bool scrollItToView)
		{
		}

		public void UnselectNode(GTreeNode node)
		{
		}

		public void ExpandAll()
		{
		}

		public void ExpandAll(GTreeNode folderNode)
		{
		}

		public void CollapseAll()
		{
		}

		public void CollapseAll(GTreeNode folderNode)
		{
		}

		private void CreateCell(GTreeNode node)
		{
		}

		internal void _AfterInserted(GTreeNode node)
		{
		}

		private int GetInsertIndexForNode(GTreeNode node)
		{
			return 0;
		}

		internal void _AfterRemoved(GTreeNode node)
		{
		}

		internal void _AfterExpanded(GTreeNode node)
		{
		}

		internal void _AfterCollapsed(GTreeNode node)
		{
		}

		internal void _AfterMoved(GTreeNode node)
		{
		}

		private int GetFolderEndIndex(int startIndex, int level)
		{
			return 0;
		}

		private int CheckChildren(GTreeNode folderNode, int index)
		{
			return 0;
		}

		private void HideFolderNode(GTreeNode folderNode)
		{
		}

		private void RemoveNode(GTreeNode node)
		{
		}

		private void __cellTouchBegin(EventContext context)
		{
		}

		private void __expandedStateChanged(EventContext context)
		{
		}

		protected override void DispatchItemEvent(GObject item, EventContext context)
		{
		}

		public override void Setup_BeforeAdd(ByteBuffer buffer, int beginPos)
		{
		}

		protected override void ReadItems(ByteBuffer buffer)
		{
		}
	}
}
