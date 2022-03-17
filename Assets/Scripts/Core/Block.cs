using FairyGUI;
using Master;
using System.Numerics;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Core
{
	public abstract class Block : MonoBehaviour
	{
		public delegate void BlockDeadCallback();

		private sealed class _003C_003Ec__DisplayClass31_0
		{
			public float cTime;

			public Block _003C_003E4__this;

			internal void _003CInitTouch_003Eb__2()
			{
			}
		}

		protected GameWorld _world;

		protected CircleCollider2D _collider;

		protected GComponent _uiObj;

		public BlockType blockType;

		public string blockKey;

		public bool isDead;

		public BigInteger initHp;

		public BigInteger curHp;

		public static float initScale;

		public float curRadius;

		public float curScale;

		protected bool IsShowingEffect;

		private BlockDeadCallback _sBlockDeadCallback;

		protected STimer _timer;

		public bool isBombing;

		private bool _isHideBossTips;

		public GComponent uiObj => null;

		public static float initRadius => 0f;

		private string _longTouchTimerName => "";

		public Vector2 position
		{
			get
			{
				return (Vector2)null;
			}
			private set
			{
			}
		}

		public Vector2 uiPos => (Vector2)null;

		public void Init(BlockType type)
		{
		}

		public virtual void OnEnterWorld(GameWorld world, string key, Vector2 pos, BigInteger oldHp)
		{
		}

		private string GetBlockUrl(BlockType type)
		{
			return "";
		}

		private void InitTouch()
		{
		}

		private void Update()
		{
		}

		private void OnTouchHit()
		{
		}

		public virtual void OnKnifeHit(BigInteger attack, [Optional] Vector2 hitPos, bool isTap = false)
		{
		}

		private void CostHp(BigInteger attack)
		{
		}

		private void OnRewardKnifeCoin(BigInteger reward)
		{
		}

		protected virtual void OnBlockDead()
		{
		}

		protected virtual void PlayDeadSound()
		{
		}

		private void UpdateHpText()
		{
		}

		protected abstract void ShowHitEffect(bool isTap);

		protected void ShowHitScale()
		{
		}

		private void ShowDeadEffect()
		{
		}

		public void RemoveFromWorld()
		{
		}

		public void SetDeadCallback(BlockDeadCallback callback)
		{
		}

		public void RemoveDeadCallback(BlockDeadCallback callback)
		{
		}

		private void _003CInitTouch_003Eb__31_0(EventContext context)
		{
		}

		private void _003CInitTouch_003Eb__31_1()
		{
		}

		private void _003CInitTouch_003Eb__31_3()
		{
		}

		private void _003CShowHitScale_003Eb__41_0()
		{
		}
	}
}
