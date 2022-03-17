using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace FairyGUI.Utils
{
	public class XML
	{
		public string name;

		public string text;

		private Dictionary<string, string> _attributes;

		private XMLList _children;

		private static Stack<XML> sNodeStack;

		public Dictionary<string, string> attributes => null;

		public XMLList elements => null;

		public static XML Create(string tag)
		{
			return null;
		}

		public XML(string XmlString)
		{
		}

		private XML()
		{
		}

		public bool HasAttribute(string attrName)
		{
			return false;
		}

		public string GetAttribute(string attrName)
		{
			return "";
		}

		public string GetAttribute(string attrName, string defValue)
		{
			return "";
		}

		public int GetAttributeInt(string attrName)
		{
			return 0;
		}

		public int GetAttributeInt(string attrName, int defValue)
		{
			return 0;
		}

		public float GetAttributeFloat(string attrName)
		{
			return 0f;
		}

		public float GetAttributeFloat(string attrName, float defValue)
		{
			return 0f;
		}

		public bool GetAttributeBool(string attrName)
		{
			return false;
		}

		public bool GetAttributeBool(string attrName, bool defValue)
		{
			return false;
		}

		public string[] GetAttributeArray(string attrName)
		{
			return null;
		}

		public string[] GetAttributeArray(string attrName, char seperator)
		{
			return null;
		}

		public Color GetAttributeColor(string attrName, Color defValue)
		{
			return (Color)null;
		}

		public Vector2 GetAttributeVector(string attrName)
		{
			return (Vector2)null;
		}

		public void SetAttribute(string attrName, string attrValue)
		{
		}

		public void SetAttribute(string attrName, bool attrValue)
		{
		}

		public void SetAttribute(string attrName, int attrValue)
		{
		}

		public void SetAttribute(string attrName, float attrValue)
		{
		}

		public void RemoveAttribute(string attrName)
		{
		}

		public XML GetNode(string selector)
		{
			return null;
		}

		public XMLList Elements()
		{
			return null;
		}

		public XMLList Elements(string selector)
		{
			return null;
		}

		public XMLList.Enumerator GetEnumerator()
		{
			return (XMLList.Enumerator)null;
		}

		public XMLList.Enumerator GetEnumerator(string selector)
		{
			return (XMLList.Enumerator)null;
		}

		public void AppendChild(XML child)
		{
		}

		public void RemoveChild(XML child)
		{
		}

		public void RemoveChildren(string selector)
		{
		}

		public void Parse(string aSource)
		{
		}

		public void Reset()
		{
		}

		public string ToXMLString(bool includeHeader)
		{
			return "";
		}

		private void ToXMLString(StringBuilder sb, int tabs)
		{
		}
	}
}
