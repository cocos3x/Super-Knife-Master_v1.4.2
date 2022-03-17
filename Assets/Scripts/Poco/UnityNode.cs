using FairyGUI;
using System.Collections.Generic;
using UnityEngine;

namespace Poco
{
	public class UnityNode : AbstractNode
	{
		public static string DefaultTypeName;

		private GameObject gameObject;

		private DisplayObject displayObject;

		private GObject gObject;

		private List<string> components;

		private Camera camera;

		private static string[] ATTR_KEYS;

		public UnityNode(GameObject obj)
		{
		}

		public override AbstractNode getParent()
		{
			return null;
		}

		public override List<AbstractNode> getChildren()
		{
			return null;
		}

		public override object getAttr(string attrName)
		{
			return null;
		}

		public override Dictionary<string, object> enumerateAttrs()
		{
			return null;
		}

		private int GameObjectLayer()
		{
			return 0;
		}

		private string GameObjectLayerName()
		{
			return "";
		}

		private string GameObjectTag()
		{
			return "";
		}

		private List<string> GameObjectAllComponents()
		{
			return null;
		}

		private Dictionary<string, float> GameObjectzOrders()
		{
			return null;
		}

		public static bool SetText(GameObject go, string textVal)
		{
			return false;
		}
	}
}
