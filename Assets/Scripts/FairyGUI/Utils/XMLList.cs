using System.Collections.Generic;

namespace FairyGUI.Utils
{
	public class XMLList
	{
		public struct Enumerator
		{
			private List<XML> _source;

			private string _selector;

			private int _index;

			private int _total;

			private XML _current;

			public XML Current => null;

			public Enumerator(List<XML> source, string selector)
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Erase()
			{
			}

			public void Reset()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass14_0
		{
			public string selector;

			internal bool _003CRemoveAll_003Eb__0(XML xml)
			{
				return false;
			}
		}

		public List<XML> rawList;

		private static List<XML> _tmpList;

		public int Count => 0;

		public XML this[int index] => null;

		public XMLList()
		{
		}

		public XMLList(List<XML> list)
		{
		}

		public void Add(XML xml)
		{
		}

		public void Clear()
		{
		}

		public Enumerator GetEnumerator()
		{
			return (Enumerator)null;
		}

		public Enumerator GetEnumerator(string selector)
		{
			return (Enumerator)null;
		}

		public XMLList Filter(string selector)
		{
			return null;
		}

		public XML Find(string selector)
		{
			return null;
		}

		public void RemoveAll(string selector)
		{
		}
	}
}
