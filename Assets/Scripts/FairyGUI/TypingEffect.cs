using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace FairyGUI
{
	public class TypingEffect
	{
		private sealed class _003CPrint_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float interval;

			public TypingEffect _003C_003E4__this;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CPrint_003Ed__17(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		protected TextField _textField;

		protected Vector3[] _backupVerts;

		protected Vector3[] _vertices;

		protected bool _stroke;

		protected bool _shadow;

		protected int _printIndex;

		protected int _mainLayerStart;

		protected int _strokeLayerStart;

		protected int _strokeDrawDirs;

		protected int _vertIndex;

		protected int _mainLayerVertCount;

		protected bool _started;

		public TypingEffect(TextField textField)
		{
		}

		public TypingEffect(GTextField textField)
		{
		}

		public void Start()
		{
		}

		public bool Print()
		{
			return false;
		}

		private void output(int vertCount)
		{
		}

		public IEnumerator Print(float interval)
		{
			return null;
		}

		public void PrintAll(float interval)
		{
		}

		public void Cancel()
		{
		}

		private void OnMeshModified()
		{
		}
	}
}
