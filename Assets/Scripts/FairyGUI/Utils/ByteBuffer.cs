using System.Collections.Generic;
using UnityEngine;

namespace FairyGUI.Utils
{
	public class ByteBuffer
	{
		public bool littleEndian;

		public string[] stringTable;

		public int version;

		private int _pointer;

		private int _offset;

		private int _length;

		private byte[] _data;

		private static byte[] temp;

		private static List<GPathPoint> helperPoints;

		public int position
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int length => 0;

		public bool bytesAvailable => false;

		public byte[] buffer
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ByteBuffer(byte[] data, int offset = 0, int length = -1)
		{
		}

		public int Skip(int count)
		{
			return 0;
		}

		public byte ReadByte()
		{
			return 0;
		}

		public byte[] ReadBytes(byte[] output, int destIndex, int count)
		{
			return null;
		}

		public byte[] ReadBytes(int count)
		{
			return null;
		}

		public ByteBuffer ReadBuffer()
		{
			return null;
		}

		public char ReadChar()
		{
			return '\0';
		}

		public bool ReadBool()
		{
			return false;
		}

		public short ReadShort()
		{
			//IL_0003: Expected I4, but got O
			return (short)(int)null;
		}

		public ushort ReadUshort()
		{
			//IL_0003: Expected I4, but got O
			return (ushort)(int)null;
		}

		public int ReadInt()
		{
			return 0;
		}

		public uint ReadUint()
		{
			return 0u;
		}

		public float ReadFloat()
		{
			return 0f;
		}

		public long ReadLong()
		{
			return 0L;
		}

		public double ReadDouble()
		{
			return 0.0;
		}

		public string ReadString()
		{
			return "";
		}

		public string ReadString(int len)
		{
			return "";
		}

		public string ReadS()
		{
			return "";
		}

		public string[] ReadSArray(int cnt)
		{
			return null;
		}

		public List<GPathPoint> ReadPath()
		{
			return null;
		}

		public void WriteS(string value)
		{
		}

		public Color ReadColor()
		{
			return (Color)null;
		}

		public bool Seek(int indexTablePos, int blockIndex)
		{
			return false;
		}
	}
}
