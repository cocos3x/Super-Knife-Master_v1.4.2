using System;

namespace Master
{
	public abstract class ISDataOption
	{
		public bool isDirty;

		public float saveInterval;

		public float savePassTime;

		public string name;

		public Type dataType;

		public abstract object storeObject
		{
			get;
			set;
		}

		public void SetDirty(bool saveOnUpdate = false)
		{
		}

		public void SaveNow()
		{
		}
	}
}
