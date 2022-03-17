using Core.skill;
using DefaultNamespace;
using Dialogs;
using FairyGUI;
using System;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

namespace Core
{
	public class GameWorld : MonoBehaviour
	{
		private sealed class _003C_003Ec__DisplayClass40_0
		{
			public bool isBoss;

			public MultipleRewardInfo rewardInfo;

			public GameWorld _003C_003E4__this;

			public bool isFirstBoss;

			public Action _003C_003E9__3;

			public EventCallback0 _003C_003E9__2;

			public Action _003C_003E9__1;

			internal void _003COnPassStage_003Eb__0()
			{
			}

			internal void _003COnPassStage_003Eb__1()
			{
			}

			internal void _003COnPassStage_003Eb__2()
			{
			}

			internal void _003COnPassStage_003Eb__3()
			{
			}
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Action _003C_003E9__43_0;

			internal void _003CCheckShowEvaluate1_003Eb__43_0()
			{
			}
		}

		private static float _invStageScaleX;

		private static float _invStageScaleY;

		private static float _stageScaleX;

		private static float _stageScaleY;

		[SerializeField]
		private PhysicsMaterial2D _wallMaterial;

		public Dictionary<string, Block> _blocks;

		public Dictionary<int, Knife> _knives;

		private List<string> _removeBlocks;

		private List<int> _removeKnives;

		public Tap tap;

		public static float topY;

		public static float bottomY;

		public static float midX;

		public static float midY;

		private bool _bossDiamondStartFly;

		public GComponent gameLayer;

		public GComponent knifeLayer;

		public GComponent blockLayer;

		public GComponent effectLayer;

		public GComponent trailLayer;

		public bool stopUpdateAttr;

		public DropDiamondEffectHelper dropDiamondEffectHelper;

		private bool _isInit;

		public bool isBossStage;

		public BigInteger blocksTotalHp => (BigInteger)null;

		public float expProgress => 0f;

		public void Init(GComponent view)
		{
		}

		private void InitListener()
		{
		}

		private void InitWallLayer()
		{
		}

		private void CreateOldBlocks()
		{
		}

		private void CreateNewStageBlocks()
		{
		}

		private void CheckBossEnter()
		{
		}

		private Block CreateBlock(BlockType type, Vector2 uiPos, string key, BigInteger curHp)
		{
			return null;
		}

		private void CreateAllKnifes()
		{
		}

		public Block GetBlockByKey(string key)
		{
			return null;
		}

		private Knife CreateKnife(int knifeId)
		{
			return null;
		}

		public Knife CreateSplitKnife(int knifeId, Knife father)
		{
			return null;
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		private void RecordBlocksInfo(bool saveNow = false)
		{
		}

		private void RemoveDeadKnives()
		{
		}

		private void RemoveDeadBlocks()
		{
		}

		private void OnPassStage()
		{
		}

		public void StartNewStage()
		{
		}

		private void OnStartStage()
		{
		}

		private void CheckShowEvaluate1(bool isFirstBoss)
		{
		}

		public void RemoveAllBlocks()
		{
		}

		public static float ToStageValue(float v)
		{
			return 0f;
		}

		public static Vector2 ToStagePoint(Vector2 pos)
		{
			return (Vector2)null;
		}

		public static Vector2 ToStageSize(Vector2 size)
		{
			return (Vector2)null;
		}

		public static Vector2 ToWorldPoint(Vector2 pos)
		{
			return (Vector2)null;
		}

		public static Vector2 ToWorldSize(Vector2 size)
		{
			return (Vector2)null;
		}

		public static float ToWorldValue(float x)
		{
			return 0f;
		}

		private void OnApplicationPause(bool pauseStatus)
		{
		}

		private void OnApplicationQuit()
		{
		}

		public Block GetLastBlock()
		{
			return null;
		}

		public void UpdateWeaponAttrs()
		{
		}

		public void StopUpdateWeaponAttrs()
		{
		}

		private void _003CInitListener_003Eb__25_0(int kId)
		{
		}

		private void _003CInitListener_003Eb__25_1(int kId)
		{
		}
	}
}
