using System;
using System.Collections.Generic;
using UnityEngine;

public class VRSupport
{
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public VRSupport _003C_003E4__this;

		public float speed;

		public Vector3 mousePosition;
	}

	private sealed class _003C_003Ec__DisplayClass6_1
	{
		public GameObject cameraContainer;

		public _003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals1;
	}

	private sealed class _003C_003Ec__DisplayClass6_2
	{
		public GameObject cameraFollower;

		public _003C_003Ec__DisplayClass6_1 CS_0024_003C_003E8__locals2;

		internal void _003CRotateObject_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass6_3
	{
		public Quaternion currentRotation;

		public _003C_003Ec__DisplayClass6_2 CS_0024_003C_003E8__locals3;

		internal void _003CRotateObject_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public VRSupport _003C_003E4__this;

		public float speed;
	}

	private sealed class _003C_003Ec__DisplayClass7_1
	{
		public GameObject toLookAt;

		public _003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals1;
	}

	private sealed class _003C_003Ec__DisplayClass7_2
	{
		public GameObject cameraContainer;

		public _003C_003Ec__DisplayClass7_1 CS_0024_003C_003E8__locals2;

		public Action _003C_003E9__1;

		internal void _003CObjectLookAt_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass7_3
	{
		public GameObject cameraFollower;

		public _003C_003Ec__DisplayClass7_2 CS_0024_003C_003E8__locals3;

		internal void _003CObjectLookAt_003Eb__0()
		{
		}
	}

	private static Queue<Action> commands;

	public void ClearCommands()
	{
	}

	public void PeekCommand()
	{
	}

	public object isVRSupported(List<object> param)
	{
		return null;
	}

	public object IsQueueEmpty(List<object> param)
	{
		return null;
	}

	public object RotateObject(List<object> param)
	{
		return null;
	}

	public object ObjectLookAt(List<object> param)
	{
		return null;
	}

	protected void rotate(GameObject go, Quaternion originalRotation, Vector3 mousePosition, float speed)
	{
	}

	protected void objectLookAt(GameObject go, GameObject toLookAt, float speed)
	{
	}

	protected void recoverOffset(GameObject subcontainter, GameObject cameraContainer, float speed)
	{
	}

	protected bool RotateObject(Quaternion originalPosition, Vector3 mousePosition, GameObject cameraContainer, float rotationSpeed = 0.125f)
	{
		return false;
	}

	protected bool ObjectLookAtObject(GameObject go, GameObject cameraContainer, float rotationSpeed = 0.125f)
	{
		return false;
	}

	protected bool ObjectRecoverOffset(GameObject subcontainer, GameObject cameraContainer, float rotationSpeed = 0.125f)
	{
		return false;
	}
}
