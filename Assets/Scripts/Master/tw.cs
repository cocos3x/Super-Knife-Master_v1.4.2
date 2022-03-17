using DG.Tweening;
using DG.Tweening.Core;
using FairyGUI;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Master
{
	public static class tw
	{
		public abstract class TWAction
		{
			protected float _duration;

			protected Ease _ease;

			protected int _loop;

			protected float _delay;

			public abstract Tween ApplyTween(GObject target);

			public virtual Tween ApplyTween(Rigidbody target)
			{
				return null;
			}

			public abstract Tween ApplyTween(Transform target);

			public virtual void ApplySequence(Sequence seq, Tween tween)
			{
			}

			public TWAction SetLoop(int loop)
			{
				return null;
			}

			public TWAction SetDelay(float delay)
			{
				return null;
			}

			public TWAction SetEase(Ease ease)
			{
				return null;
			}
		}

		private class TWMoveTo : TWAction
		{
			private sealed class _003C_003Ec__DisplayClass4_0
			{
				public GObject target;

				internal Vector3 _003CApplyTween_003Eg__Getter_007C0()
				{
					return (Vector3)null;
				}

				internal void _003CApplyTween_003Eg__Setter_007C1(Vector3 pos)
				{
				}
			}

			private sealed class _003C_003Ec__DisplayClass5_0
			{
				public Transform target;

				public TWMoveTo _003C_003E4__this;

				internal Vector3 _003CApplyTween_003Eg__Getter_007C0()
				{
					return (Vector3)null;
				}

				internal void _003CApplyTween_003Eg__Setter_007C1(Vector3 pos)
				{
				}
			}

			private sealed class _003C_003Ec__DisplayClass6_0
			{
				public Rigidbody target;

				public TWMoveTo _003C_003E4__this;

				internal Vector3 _003CApplyTween_003Eg__Getter_007C0()
				{
					return (Vector3)null;
				}

				internal void _003CApplyTween_003Eg__Setter_007C1(Vector3 pos)
				{
				}
			}

			protected readonly Vector3 _position;

			protected readonly bool _isMoveZ;

			internal TWMoveTo(float duration, float x, float y, Ease ease)
			{
			}

			internal TWMoveTo(float duration, float x, float y, float z, Ease ease)
			{
			}

			public override Tween ApplyTween(GObject target)
			{
				return null;
			}

			public override Tween ApplyTween(Transform target)
			{
				return null;
			}

			public override Tween ApplyTween(Rigidbody target)
			{
				return null;
			}
		}

		private class TWMoveBy : TWMoveTo
		{
			internal TWMoveBy(float duration, float x, float y, Ease ease)
			{
			}

			internal TWMoveBy(float duration, float x, float y, float z, Ease ease)
			{
			}

			public override Tween ApplyTween(GObject target)
			{
				return null;
			}

			public override Tween ApplyTween(Transform target)
			{
				return null;
			}

			public override Tween ApplyTween(Rigidbody target)
			{
				return null;
			}
		}

		private class TWMoveAxisTo : TWAction
		{
			private sealed class _003C_003Ec__DisplayClass3_0
			{
				public GObject target;

				internal Vector3 _003CApplyTween_003Eb__0()
				{
					return (Vector3)null;
				}

				internal void _003CApplyTween_003Eb__1(Vector3 pos)
				{
				}
			}

			private sealed class _003C_003Ec__DisplayClass4_0
			{
				public Transform target;

				internal Vector3 _003CApplyTween_003Eb__0()
				{
					return (Vector3)null;
				}

				internal void _003CApplyTween_003Eb__1(Vector3 pos)
				{
				}
			}

			private sealed class _003C_003Ec__DisplayClass5_0
			{
				public Rigidbody target;

				internal Vector3 _003CApplyTween_003Eb__0()
				{
					return (Vector3)null;
				}
			}

			protected readonly float _value;

			protected readonly AxisConstraint _axis;

			internal TWMoveAxisTo(float duration, float v, AxisConstraint axis, Ease ease)
			{
			}

			public override Tween ApplyTween(GObject target)
			{
				return null;
			}

			public override Tween ApplyTween(Transform target)
			{
				return null;
			}

			public override Tween ApplyTween(Rigidbody target)
			{
				return null;
			}
		}

		private class TWMoveAxisBy : TWMoveAxisTo
		{
			internal TWMoveAxisBy(float duration, float v, AxisConstraint axis, Ease ease)
			{
			}

			public override Tween ApplyTween(GObject target)
			{
				return null;
			}

			public override Tween ApplyTween(Transform target)
			{
				return null;
			}
		}

		private class TWScaleTo : TWAction
		{
			private sealed class _003C_003Ec__DisplayClass4_0
			{
				public GObject target;

				internal Vector2 _003CApplyTween_003Eg__Getter_007C0()
				{
					return (Vector2)null;
				}

				internal void _003CApplyTween_003Eg__Setter_007C1(Vector2 v)
				{
				}
			}

			private sealed class _003C_003Ec__DisplayClass5_0
			{
				public Transform target;

				public TWScaleTo _003C_003E4__this;

				internal Vector3 _003CApplyTween_003Eg__Getter_007C0()
				{
					return (Vector3)null;
				}

				internal void _003CApplyTween_003Eg__Setter_007C1(Vector3 v)
				{
				}
			}

			protected readonly Vector3 _scale;

			protected readonly bool isScaleZ;

			internal TWScaleTo(float duration, float x, float y, Ease ease)
			{
			}

			internal TWScaleTo(float duration, float x, float y, float z, Ease ease)
			{
			}

			public override Tween ApplyTween(GObject target)
			{
				return null;
			}

			public override Tween ApplyTween(Transform target)
			{
				return null;
			}
		}

		private class TWScaleBy : TWScaleTo
		{
			internal TWScaleBy(float duration, float x, float y, Ease ease)
			{
			}

			internal TWScaleBy(float duration, float x, float y, float z, Ease ease)
			{
			}

			public override Tween ApplyTween(GObject target)
			{
				return null;
			}

			public override Tween ApplyTween(Transform target)
			{
				return null;
			}
		}

		private class TWShake : TWAction
		{
			private sealed class _003C_003Ec__DisplayClass4_0
			{
				public GObject target;

				internal Vector3 _003CApplyTween_003Eg__Getter_007C0()
				{
					return (Vector3)null;
				}

				internal void _003CApplyTween_003Eg__Setter_007C1(Vector3 v)
				{
				}
			}

			private sealed class _003C_003Ec__DisplayClass5_0
			{
				public Transform target;

				internal Vector3 _003CApplyTween_003Eg__Getter_007C0()
				{
					return (Vector3)null;
				}

				internal void _003CApplyTween_003Eg__Setter_007C1(Vector3 v)
				{
				}
			}

			private readonly float _strength;

			private int _vibrato;

			private float _randomness;

			internal TWShake(float duration, float strength, Ease ease)
			{
			}

			public override Tween ApplyTween(GObject target)
			{
				return null;
			}

			public override Tween ApplyTween(Transform target)
			{
				return null;
			}
		}

		private class TWTextIntFromTo : TWAction
		{
			private sealed class _003C_003Ec__DisplayClass6_0
			{
				public TWTextIntFromTo _003C_003E4__this;

				public GObject target;

				internal long _003CApplyTween_003Eg__Getter_007C0()
				{
					return 0L;
				}

				internal void _003CApplyTween_003Eg__Setter_007C1(long v)
				{
				}
			}

			private readonly long _fromV;

			private readonly long _toV;

			private string _prefix;

			private string _suffix;

			private int _numberMode;

			internal TWTextIntFromTo(float duration, long fromValue, long toValue, int numberMode, string prefix, string suffix, Ease ease)
			{
			}

			public override Tween ApplyTween(GObject target)
			{
				return null;
			}

			public override Tween ApplyTween(Transform target)
			{
				return null;
			}
		}

		private class TWNumberFromTo : TWAction
		{
			private readonly float _fromV;

			private readonly float _toV;

			private readonly DOSetter<float> _stepCallback;

			internal TWNumberFromTo(float duration, float fromValue, float toValue, DOSetter<float> stepCallback, Ease ease)
			{
			}

			public override Tween ApplyTween(GObject target)
			{
				return null;
			}

			public override Tween ApplyTween(Transform target)
			{
				return null;
			}

			private float _003CApplyTween_003Eg__Getter_007C4_0()
			{
				return 0f;
			}

			private float _003CApplyTween_003Eg__Getter_007C5_0()
			{
				return 0f;
			}
		}

		private class TWSequence : TWAction
		{
			private readonly TWAction[] _actionList;

			public TWSequence(TWAction[] args)
			{
			}

			public override Tween ApplyTween(GObject target)
			{
				return null;
			}

			public override Tween ApplyTween(Transform target)
			{
				return null;
			}
		}

		private class TWRemoveSelf : TWAction
		{
			private sealed class _003C_003Ec__DisplayClass2_0
			{
				public Transform target;

				internal void _003CApplyTween_003Eb__0()
				{
				}
			}

			private sealed class _003C_003Ec__DisplayClass3_0
			{
				public Rigidbody target;

				internal void _003CApplyTween_003Eb__0()
				{
				}
			}

			internal TWRemoveSelf(float duration)
			{
			}

			public override Tween ApplyTween(GObject target)
			{
				return null;
			}

			public override Tween ApplyTween(Transform target)
			{
				return null;
			}

			public override Tween ApplyTween(Rigidbody target)
			{
				return null;
			}
		}

		private class TWCallback : TWAction
		{
			private TweenCallback _callback;

			internal TWCallback(float duration, TweenCallback callback)
			{
			}

			public override Tween ApplyTween(GObject target)
			{
				return null;
			}

			public override Tween ApplyTween(Transform target)
			{
				return null;
			}

			public override Tween ApplyTween(Rigidbody target)
			{
				return null;
			}
		}

		private class TWDelay : TWAction
		{
			internal TWDelay(float duration)
			{
			}

			public override Tween ApplyTween(GObject target)
			{
				return null;
			}

			public override Tween ApplyTween(Transform target)
			{
				return null;
			}

			public override void ApplySequence(Sequence seq, Tween tween)
			{
			}
		}

		private class TWAlphaTo : TWAction
		{
			private sealed class _003C_003Ec__DisplayClass2_0
			{
				public GObject target;

				internal float _003CApplyTween_003Eb__0()
				{
					return 0f;
				}

				internal void _003CApplyTween_003Eb__1(float v)
				{
				}
			}

			[Serializable]
			private sealed class _003C_003Ec
			{
				public static readonly _003C_003Ec _003C_003E9;

				public static DOGetter<float> _003C_003E9__3_0;

				public static DOSetter<float> _003C_003E9__3_1;

				internal float _003CApplyTween_003Eb__3_0()
				{
					return 0f;
				}

				internal void _003CApplyTween_003Eb__3_1(float v)
				{
				}
			}

			private readonly float _alpha;

			internal TWAlphaTo(float duration, float alpha)
			{
			}

			public override Tween ApplyTween(GObject target)
			{
				return null;
			}

			public override Tween ApplyTween(Transform target)
			{
				return null;
			}
		}

		private class TWBezierFromTo : TWAction
		{
			private sealed class _003C_003Ec__DisplayClass10_0
			{
				public TWBezierFromTo _003C_003E4__this;

				public GObject target;

				internal void _003CApplyTween_003Eg__Setter_007C0(float ratio)
				{
				}
			}

			[Serializable]
			private sealed class _003C_003Ec
			{
				public static readonly _003C_003Ec _003C_003E9;

				public static DOGetter<float> _003C_003E9__10_1;

				internal float _003CApplyTween_003Eb__10_1()
				{
					return 0f;
				}
			}

			private readonly double _endY;

			private readonly double _endX;

			private readonly double _startY;

			private readonly double _startX;

			private readonly double _control1X;

			private readonly double _control1Y;

			private readonly double _control2X;

			private readonly double _control2Y;

			internal TWBezierFromTo(float duration, float fromX, float fromY, float tox, float toy, float length1, float height1, float length2, float height2, int dir)
			{
			}

			private static double BezierRat(double a, double b, double c, double d, double t)
			{
				return 0.0;
			}

			public override Tween ApplyTween(GObject target)
			{
				return null;
			}

			public override Tween ApplyTween(Transform target)
			{
				return null;
			}
		}

		private class TWBezierFromToXZY : TWAction
		{
			private sealed class _003C_003Ec__DisplayClass14_0
			{
				public TWBezierFromToXZY _003C_003E4__this;

				public Transform target;

				internal void _003CApplyTween_003Eg__Setter_007C0(float ratio)
				{
				}
			}

			[Serializable]
			private sealed class _003C_003Ec
			{
				public static readonly _003C_003Ec _003C_003E9;

				public static DOGetter<float> _003C_003E9__14_1;

				internal float _003CApplyTween_003Eb__14_1()
				{
					return 0f;
				}
			}

			private readonly double _endY;

			private readonly double _endX;

			private readonly double _endZ;

			private readonly double _startY;

			private readonly double _startX;

			private readonly double _startZ;

			private readonly double _control1X;

			private readonly double _control1Y;

			private readonly double _control1Z;

			private readonly double _control2X;

			private readonly double _control2Y;

			private readonly double _control2Z;

			internal TWBezierFromToXZY(float duration, float fromX, float fromY, float fromZ, float tox, float toy, float toz, float length1, float height1, float length2, float height2, int dir)
			{
			}

			private static double BezierRat(double a, double b, double c, double d, double t)
			{
				return 0.0;
			}

			public override Tween ApplyTween(Transform target)
			{
				return null;
			}

			public override Tween ApplyTween(GObject target)
			{
				return null;
			}
		}

		private class TWPath : TWAction
		{
			private sealed class _003C_003Ec__DisplayClass6_0
			{
				public Transform target;

				internal Vector3 _003CApplyTween_003Eb__0()
				{
					return (Vector3)null;
				}

				internal void _003CApplyTween_003Eb__1(Vector3 x)
				{
				}
			}

			private sealed class _003C_003Ec__DisplayClass7_0
			{
				public GObject target;

				internal Vector3 _003CApplyTween_003Eb__0()
				{
					return (Vector3)null;
				}

				internal void _003CApplyTween_003Eb__1(Vector3 x)
				{
				}
			}

			private Vector3[] _path;

			private PathType _pathType;

			private PathMode _pathMode;

			private int _resolution;

			private Color? _gizmoColor;

			internal TWPath(float duration, Vector3[] path, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
			{
			}

			public override Tween ApplyTween(Transform target)
			{
				return null;
			}

			public override Tween ApplyTween(GObject target)
			{
				return null;
			}
		}

		private class TWRotateBy : TWRotateTo
		{
			private sealed class _003C_003Ec__DisplayClass1_0
			{
				public GObject target;

				internal float _003CApplyTween_003Eg__Getter_007C0()
				{
					return 0f;
				}

				internal void _003CApplyTween_003Eg__Setter_007C1(float r)
				{
				}
			}

			internal TWRotateBy(float duration, float rotation, Ease ease)
			{
			}

			public override Tween ApplyTween(GObject target)
			{
				return null;
			}
		}

		private class TWRotateTo : TWAction
		{
			private sealed class _003C_003Ec__DisplayClass2_0
			{
				public GObject target;

				internal float _003CApplyTween_003Eg__Getter_007C0()
				{
					return 0f;
				}

				internal void _003CApplyTween_003Eg__Setter_007C1(float r)
				{
				}
			}

			protected readonly float _rotation;

			internal TWRotateTo(float duration, float rotation, Ease ease)
			{
			}

			public override Tween ApplyTween(GObject target)
			{
				return null;
			}

			public override Tween ApplyTween(Transform target)
			{
				return null;
			}
		}

		private class TWRotateXTo : TWRotateTo
		{
			private sealed class _003C_003Ec__DisplayClass1_0
			{
				public Transform target;

				internal float _003CApplyTween_003Eg__Getter_007C0()
				{
					return 0f;
				}

				internal void _003CApplyTween_003Eg__Setter_007C1(float r)
				{
				}
			}

			internal TWRotateXTo(float duration, float rotation, Ease ease)
			{
			}

			public override Tween ApplyTween(Transform target)
			{
				return null;
			}
		}

		private class TWRotateYTo : TWRotateTo
		{
			private sealed class _003C_003Ec__DisplayClass1_0
			{
				public Transform target;

				internal float _003CApplyTween_003Eg__Getter_007C0()
				{
					return 0f;
				}

				internal void _003CApplyTween_003Eg__Setter_007C1(float r)
				{
				}
			}

			internal TWRotateYTo(float duration, float rotation, Ease ease)
			{
			}

			public override Tween ApplyTween(Transform target)
			{
				return null;
			}
		}

		private class TWRotateZTo : TWRotateTo
		{
			private sealed class _003C_003Ec__DisplayClass1_0
			{
				public Transform target;

				internal float _003CApplyTween_003Eg__Getter_007C0()
				{
					return 0f;
				}

				internal void _003CApplyTween_003Eg__Setter_007C1(float r)
				{
				}
			}

			internal TWRotateZTo(float duration, float rotation, Ease ease)
			{
			}

			public override Tween ApplyTween(Transform target)
			{
				return null;
			}
		}

		private class TWRotateXBy : TWRotateXTo
		{
			internal TWRotateXBy(float duration, float rotation, Ease ease)
			{
			}

			public override Tween ApplyTween(GObject target)
			{
				return null;
			}

			public override Tween ApplyTween(Transform target)
			{
				return null;
			}
		}

		private class TWRotateYBy : TWRotateYTo
		{
			internal TWRotateYBy(float duration, float rotation, Ease ease)
			{
			}

			public override Tween ApplyTween(GObject target)
			{
				return null;
			}

			public override Tween ApplyTween(Transform target)
			{
				return null;
			}
		}

		private class TWRotateZBy : TWRotateYTo
		{
			internal TWRotateZBy(float duration, float rotation, Ease ease)
			{
			}

			public override Tween ApplyTween(GObject target)
			{
				return null;
			}

			public override Tween ApplyTween(Transform target)
			{
				return null;
			}
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Action<Tween> _003C_003E9__65_0;

			public static Action<Tween> _003C_003E9__65_1;

			public static Action<LinkedListNode<Tween>> _003C_003E9__65_2;

			public static Action<LinkedListNode<Tween>> _003C_003E9__65_3;

			internal void _003CClearAllTween_003Eb__65_0(Tween ele)
			{
			}

			internal void _003CClearAllTween_003Eb__65_1(Tween ele)
			{
			}

			internal void _003CClearAllTween_003Eb__65_2(LinkedListNode<Tween> ele)
			{
			}

			internal void _003CClearAllTween_003Eb__65_3(LinkedListNode<Tween> ele)
			{
			}

			internal float _003C_002Ecctor_003Eb__84_0()
			{
				return 0f;
			}

			internal void _003C_002Ecctor_003Eb__84_1(float v)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass68_0
		{
			public List<Tween> tweenList;

			public Tween t;

			internal void _003CRunTween_003Eb__0()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass69_0
		{
			public LinkedListNode<Tween> node;

			public List<LinkedListNode<Tween>> tweenList;

			internal void _003CRunTweenX_003Eb__0()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass71_0
		{
			public List<Tween> tweenList;

			public Tween t;

			public int hashCode;

			internal void _003CRunTween_003Eb__0()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass72_0
		{
			public LinkedListNode<Tween> node;

			public List<LinkedListNode<Tween>> tweenList;

			internal void _003CRunTweenX_003Eb__0()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass73_0
		{
			public LinkedListNode<Tween> node;

			public List<LinkedListNode<Tween>> tweenList;

			internal void _003CRunTweenX_003Eb__0()
			{
			}
		}

		private static readonly DOGetter<float> s_emptyFloatGetter;

		private static readonly DOSetter<float> s_emptyFloatSetter;

		private static readonly Dictionary<EventDispatcher, List<Tween>> s_allTweenA;

		private static readonly Dictionary<EventDispatcher, List<LinkedListNode<Tween>>> s_allTweenX;

		private static readonly LinkedList<Tween> s_allTweenListX;

		private static readonly Dictionary<int, List<LinkedListNode<Tween>>> s_allTweenY;

		private static readonly Dictionary<int, List<Tween>> s_allTweenB;

		public static TWAction Path(float duration, Vector3[] path, Ease ease = Ease.Linear, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		public static TWAction MoveByX(float duration, float x, Ease ease = Ease.Linear)
		{
			return null;
		}

		public static TWAction MoveToX(float duration, float x, Ease ease = Ease.Linear)
		{
			return null;
		}

		public static TWAction MoveByY(float duration, float y, Ease ease = Ease.Linear)
		{
			return null;
		}

		public static TWAction MoveToY(float duration, float y, Ease ease = Ease.Linear)
		{
			return null;
		}

		public static TWAction MoveByZ(float duration, float z, Ease ease = Ease.Linear)
		{
			return null;
		}

		public static TWAction MoveToZ(float duration, float z, Ease ease = Ease.Linear)
		{
			return null;
		}

		public static TWAction MoveTo(float duration, Vector2 pos, Ease ease = Ease.Linear)
		{
			return null;
		}

		public static TWAction MoveBy(float duration, Vector2 pos, Ease ease = Ease.Linear)
		{
			return null;
		}

		public static TWAction MoveTo(float duration, float x, float y, Ease ease = Ease.Linear)
		{
			return null;
		}

		public static TWAction MoveTo(float duration, float x, float y, float z, Ease ease = Ease.Linear)
		{
			return null;
		}

		public static TWAction MoveBy(float duration, float x, float y, Ease ease = Ease.Linear)
		{
			return null;
		}

		public static TWAction MoveBy(float duration, float x, float y, float z, Ease ease = Ease.Linear)
		{
			return null;
		}

		public static TWAction AlphaTo(float duration, float alpha, Ease ease = Ease.Linear)
		{
			return null;
		}

		public static TWAction ScaleTo(float duration, float scale, Ease ease = Ease.Linear)
		{
			return null;
		}

		public static TWAction ScaleTo(float duration, float scaleX, float scaleY, Ease ease = Ease.Linear)
		{
			return null;
		}

		public static TWAction ScaleTo(float duration, Vector2 scale, Ease ease = Ease.Linear)
		{
			return null;
		}

		public static TWAction ScaleTo(float duration, float scaleX, float scaleY, float scaleZ, Ease ease = Ease.Linear)
		{
			return null;
		}

		public static TWAction ScaleBy(float duration, float scale, Ease ease = Ease.Linear)
		{
			return null;
		}

		public static TWAction ScaleBy(float duration, float scaleX, float scaleY, Ease ease = Ease.Linear)
		{
			return null;
		}

		public static TWAction ScaleBy(float duration, Vector2 scale, Ease ease = Ease.Linear)
		{
			return null;
		}

		public static TWAction ScaleBy(float duration, float scaleX, float scaleY, float scaleZ, Ease ease = Ease.Linear)
		{
			return null;
		}

		public static TWAction RotateBy(float duration, float rotation, Ease ease = Ease.Linear)
		{
			return null;
		}

		public static TWAction RotateXTo(float duration, float rotation, Ease ease = Ease.Linear)
		{
			return null;
		}

		public static TWAction RotateXBy(float duration, float rotation, Ease ease = Ease.Linear)
		{
			return null;
		}

		public static TWAction RotateYTo(float duration, float rotation, Ease ease = Ease.Linear)
		{
			return null;
		}

		public static TWAction RotateYBy(float duration, float rotation, Ease ease = Ease.Linear)
		{
			return null;
		}

		public static TWAction RotateZTo(float duration, float rotation, Ease ease = Ease.Linear)
		{
			return null;
		}

		public static TWAction RotateZBy(float duration, float rotation, Ease ease = Ease.Linear)
		{
			return null;
		}

		public static TWAction RotateTo(float duration, float rotation, Ease ease = Ease.Linear)
		{
			return null;
		}

		public static TWAction Shake(float duration, float strength, Ease ease = Ease.Linear)
		{
			return null;
		}

		public static TWAction BezierFromTo(float duration, float fromX, float fromY, float tox, float toy, float length1, float height1, float length2, float height2, int dir)
		{
			return null;
		}

		public static TWAction BezierFromTo(float duration, Vector3 fromPos, Vector3 toPos, float length1, float height1, float length2, float height2, int dir)
		{
			return null;
		}

		public static TWAction RemoveSelf(float duration = 0f)
		{
			return null;
		}

		public static TWAction Delay(float duration = 0f)
		{
			return null;
		}

		public static TWAction Callback(TweenCallback callback)
		{
			return null;
		}

		public static TWAction Callback(float duration, TweenCallback callback)
		{
			return null;
		}

		public static TWAction TextIntFromTo(float duration, long fromValue, long toValue, int numberMode, string prefix, string suffix, Ease ease = Ease.Linear)
		{
			return null;
		}

		public static TWAction NumberFromTo(float duration, float fromValue, float toValue, DOSetter<float> stepCallback, Ease ease = Ease.Linear)
		{
			return null;
		}

		public static TWAction Sequence(params TWAction[] args)
		{
			return null;
		}

		public static void ClearAllTween()
		{
		}

		private static void OnTargetRemovedFromStage(EventContext e)
		{
		}

		private static void OnTargetRemovedFromStageX(EventContext e)
		{
		}

		public static Tween RunTween(this GObject target, TWAction action)
		{
			return null;
		}

		public static Tween RunTweenX(this GObject target, TWAction action)
		{
			return null;
		}

		public static void StopAllTween(this GObject target)
		{
		}

		public static Tween RunTween(this Transform target, TWAction action)
		{
			return null;
		}

		public static Tween RunTweenX(this Transform target, TWAction action)
		{
			return null;
		}

		public static Tween RunTweenX(this Rigidbody target, TWAction action)
		{
			return null;
		}

		public static void StopAllTween(this Transform target)
		{
		}

		public static void UpdateTweenX(float dt)
		{
		}
	}
}
