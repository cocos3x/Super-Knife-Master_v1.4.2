using DG.Tweening.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using System.Runtime.InteropServices;
using UnityEngine;

namespace DG.Tweening
{
	public static class DOTweenModulePhysics
	{
		private sealed class _003C_003Ec__DisplayClass0_0
		{
			public Rigidbody target;

			internal Vector3 _003CDOMove_003Eb__0()
			{
				return (Vector3)null;
			}
		}

		private sealed class _003C_003Ec__DisplayClass1_0
		{
			public Rigidbody target;

			internal Vector3 _003CDOMoveX_003Eb__0()
			{
				return (Vector3)null;
			}
		}

		private sealed class _003C_003Ec__DisplayClass2_0
		{
			public Rigidbody target;

			internal Vector3 _003CDOMoveY_003Eb__0()
			{
				return (Vector3)null;
			}
		}

		private sealed class _003C_003Ec__DisplayClass3_0
		{
			public Rigidbody target;

			internal Vector3 _003CDOMoveZ_003Eb__0()
			{
				return (Vector3)null;
			}
		}

		private sealed class _003C_003Ec__DisplayClass4_0
		{
			public Rigidbody target;

			internal Quaternion _003CDORotate_003Eb__0()
			{
				return (Quaternion)null;
			}
		}

		private sealed class _003C_003Ec__DisplayClass5_0
		{
			public Rigidbody target;

			internal Quaternion _003CDOLookAt_003Eb__0()
			{
				return (Quaternion)null;
			}
		}

		private sealed class _003C_003Ec__DisplayClass6_0
		{
			public Rigidbody target;

			public float startPosY;

			public bool offsetYSet;

			public float offsetY;

			public Sequence s;

			public Vector3 endValue;

			public Tween yTween;

			internal Vector3 _003CDOJump_003Eb__0()
			{
				return (Vector3)null;
			}

			internal void _003CDOJump_003Eb__1()
			{
			}

			internal Vector3 _003CDOJump_003Eb__2()
			{
				return (Vector3)null;
			}

			internal Vector3 _003CDOJump_003Eb__3()
			{
				return (Vector3)null;
			}

			internal void _003CDOJump_003Eb__4()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass7_0
		{
			public Rigidbody target;

			internal Vector3 _003CDOPath_003Eb__0()
			{
				return (Vector3)null;
			}
		}

		private sealed class _003C_003Ec__DisplayClass8_0
		{
			public Transform trans;

			public Rigidbody target;

			internal Vector3 _003CDOLocalPath_003Eb__0()
			{
				return (Vector3)null;
			}

			internal void _003CDOLocalPath_003Eb__1(Vector3 x)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass9_0
		{
			public Rigidbody target;

			internal Vector3 _003CDOPath_003Eb__0()
			{
				return (Vector3)null;
			}
		}

		private sealed class _003C_003Ec__DisplayClass10_0
		{
			public Transform trans;

			public Rigidbody target;

			internal Vector3 _003CDOLocalPath_003Eb__0()
			{
				return (Vector3)null;
			}

			internal void _003CDOLocalPath_003Eb__1(Vector3 x)
			{
			}
		}

		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
		{
			return null;
		}

		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
}
