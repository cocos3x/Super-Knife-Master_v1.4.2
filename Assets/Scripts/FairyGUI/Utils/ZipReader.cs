namespace FairyGUI.Utils
{
	public class ZipReader
	{
		public class ZipEntry
		{
			public string name;

			public int compress;

			public uint crc;

			public int size;

			public int sourceSize;

			public int offset;

			public bool isDirectory;
		}

		private ByteBuffer _stream;

		private int _entryCount;

		private int _pos;

		private int _index;

		public int entryCount => 0;

		public ZipReader(byte[] data)
		{
		}

		public bool GetNextEntry(ZipEntry entry)
		{
			return false;
		}

		public byte[] GetEntryData(ZipEntry entry)
		{
			return null;
		}
	}
}
