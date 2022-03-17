using DG.Tweening.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using System.Runtime.InteropServices;
using UnityEngine;

namespace DG.Tweening
{
	public static class DOTweenModulePhysics2D
	{
		private sealed class _003C_003Ec__DisplayClass0_0
		{
			public Rigidbody2D target;

			internal Vector2 _003CDOMove_003Eb__0()
			{
				return (Vector2)null;
			}
		}

		private sealed class _003C_003Ec__DisplayClass1_0
		{
			public Rigidbody2D target;

			internal Vector2 _003CDOMoveX_003Eb__0()
			{
				return (Vector2)null;
			}
		}

		private sealed class _003C_003Ec__DisplayClass2_0
		{
			public Rigidbody2D target;

			internal Vector2 _003CDOMoveY_003Eb__0()
			{
				return (Vector2)null;
			}
		}

		private sealed class _003C_003Ec__DisplayClass3_0
		{
			public Rigidbody2D target;

			internal float _003CDORotate_003Eb__0()
			{
				return 0f;
			}
		}

		private sealed class _003C_003Ec__DisplayClass4_0
		{
			public Rigidbody2D target;

			public float startPosY;

			public bool offsetYSet;

			public float offsetY;

			public Sequence s;

			public Vector2 endValue;

			public Tween yTween;

			internal Vector2 _003CDOJump_003Eb__0()
			{
				return (Vector2)null;
			}

			internal void _003CDOJump_003Eb__1(Vector2 x)
			{
			}

			internal void _003CDOJump_003Eb__2()
			{
			}

			internal Vector2 _003CDOJump_003Eb__3()
			{
				return (Vector2)null;
			}

			internal void _003CDOJump_003Eb__4(Vector2 x)
			{
			}

			internal void _003CDOJump_003Eb__5()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass5_0
		{
			public Rigidbody2D target;

			internal Vector3 _003CDOPath_003Eb__0()
			{
				return (Vector3)null;
			}

			internal void _003CDOPath_003Eb__1(Vector3 x)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass6_0
		{
			public Transform trans;

			public Rigidbody2D target;

			internal Vector3 _003CDOLocalPath_003Eb__0()
			{
				return (Vector3)null;
			}

			internal void _003CDOLocalPath_003Eb__1(Vector3 x)
			{
			}
		}

		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
		{
			return null;
		}

		public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}
	}
}
