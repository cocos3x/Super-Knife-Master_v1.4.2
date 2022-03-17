using FairyGUI;
using System.Collections.Generic;

namespace Master
{
	public class STopUILayer : GComponent
	{
		private static STopUILayer s_instance;

		private readonly Dictionary<string, GComponent> _layers;

		public static STopUILayer instance => null;

		public GComponent this[string layerName] => null;

		protected GComponent CreateLayer(string layerName)
		{
			return null;
		}

		public GComponent GetLayer(string layerName)
		{
			return null;
		}

		public GComponent SetLayerOrder(string layerName, int order)
		{
			return null;
		}
	}
}
