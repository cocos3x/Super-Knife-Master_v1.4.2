using System.Collections.Generic;

namespace sdk.analy
{
	public class Track
	{
		private const string EbKey1 = "eb_key1";

		private const string EbKey2 = "eb_key2";

		private const string SplitKey = ",";

		private const string SplitArray = "#";

		private readonly short _src;

		private readonly string _name;

		private readonly Dictionary<string, string> _dictionary;

		public Track(short src, string name)
		{
		}

		public Track Put(string key, string value)
		{
			return null;
		}

		public Track Put(Dictionary<string, string> keyValues)
		{
			return null;
		}

		public Track Put12(string value1, string value2)
		{
			return null;
		}

		public Track Put(string key, int value)
		{
			return null;
		}

		public Track Put(string key, long value)
		{
			return null;
		}

		public Track Put(string key, bool value)
		{
			return null;
		}

		public Track Put1(int value)
		{
			return null;
		}

		public Track Put1(string value)
		{
			return null;
		}

		public Track Put2(int value)
		{
			return null;
		}

		public Track Put2(string value)
		{
			return null;
		}

		public Track Put12(int value1, int value2)
		{
			return null;
		}

		public Track Put12(string value1, int value2)
		{
			return null;
		}

		public Track Put12(int value1, string value2)
		{
			return null;
		}

		public void Commit()
		{
		}
	}
}
