using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FairyGUI.Utils
{
	public class HtmlElement
	{
		public HtmlElementType type;

		public string name;

		public string text;

		public TextFormat format;

		public int charIndex;

		public IHtmlObject htmlObject;

		public int status;

		public int space;

		public Vector2 position;

		private Hashtable attributes;

		private static Stack<HtmlElement> elementPool;

		public bool isEntity => false;

		public object Get(string attrName)
		{
			return null;
		}

		public void Set(string attrName, object attrValue)
		{
		}

		public string GetString(string attrName)
		{
			return "";
		}

		public string GetString(string attrName, string defValue)
		{
			return "";
		}

		public int GetInt(string attrName)
		{
			return 0;
		}

		public int GetInt(string attrName, int defValue)
		{
			return 0;
		}

		public float GetFloat(string attrName)
		{
			return 0f;
		}

		public float GetFloat(string attrName, float defValue)
		{
			return 0f;
		}

		public bool GetBool(string attrName)
		{
			return false;
		}

		public bool GetBool(string attrName, bool defValue)
		{
			return false;
		}

		public Color GetColor(string attrName, Color defValue)
		{
			return (Color)null;
		}

		public void FetchAttributes()
		{
		}

		public static HtmlElement GetElement(HtmlElementType type)
		{
			return null;
		}

		public static void ReturnElement(HtmlElement element)
		{
		}

		public static void ReturnElements(List<HtmlElement> elements)
		{
		}
	}
}
