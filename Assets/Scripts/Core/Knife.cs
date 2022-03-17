using Core.skill;
using ExcelConfig;
using FairyGUI;
using Presenter;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

namespace Core
{
	public class Knife : MonoBehaviour
	{
		private GameWorld _003Cworld_003Ek__BackingField;

		private GComponent _uiObj;

		public bool isDead;

		public Rigidbody2D _body;

		public CircleCollider2D _collider;

		public SkillMgr skillMgr;

		public float speed;

		public int knifeId;

		public int lv;

		public int hp;

		private bool isSplit;

		public Knife splitFather;

		public KnifeType knifeType;

		private int _lastBlockIndex;

		private List<Vector2> _hitWallPosRecordList;

		private KnifeLocalConfig _config;

		public Vector2 lastPosition;

		public bool stopAutoFly;

		private KnifeLocalConfig _knifeConfig;

		private GameObject _trailObj;

		private TrailRenderer _trailRenderer;

		public BigInteger realAtk;

		private static Dictionary<string, int[]> angleList;

		public GameWorld world
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GComponent uiObj => null;

		public Vector2 position => (Vector2)null;

		public int splitKnifeId => 0;

		public void Init(KnifeType poolId)
		{
		}

		private void InitListener()
		{
		}

		public void OnEnterWorld(int kid)
		{
		}

		private void RunUiObjAction()
		{
		}

		public void UpdateAttr()
		{
		}

		public void OnReturnToPool()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		private void FixedUpdate()
		{
		}

		private void OnCollisionEnter2D(Collision2D other)
		{
		}

		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		private void OnHitWall(string wallName)
		{
		}

		private void CheckLastBlock()
		{
		}

		private void CheckVelocity()
		{
		}

		private Vector2 GetRandomV()
		{
			return (Vector2)null;
		}

		private void CheckRepeatPos(string wallName)
		{
		}

		private void OnHitBlock(Block block)
		{
		}

		private void ShowHitBlockEffect(Vector2 pos)
		{
		}

		private void SyncBodyToView()
		{
		}

		private void SyncViewToBody()
		{
		}

		public void UpdateVelocity()
		{
		}

		public void MoveToBlock(Vector2 blockPos)
		{
		}

		public void RemoveFromWorld()
		{
		}

		private void SetTrail()
		{
		}

		private void _003CInitListener_003Eb__30_0(int kId)
		{
		}
	}
}
