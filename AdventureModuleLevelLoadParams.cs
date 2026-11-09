using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AK.Wwise;
using LitJson;
using Nova.Hotfix;
using TrueSync;
using UnityEngine;
using UnityEngine.UI.Extensions;

[Serializable]
public class AdventureModuleLevelLoadParams
{
	public struct MapGroupStageCount
	{
		public int stage;

		public int group;

		public int count;

		public MapGroupStageCount(int stage, int group, int count)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
				{
					/*Error: Invalid branch target*/;
				}
				_ = (ulong)/*Error near IL_0007: Stack underflow*/;
			}
			_ = -(nint)1723988484;
			/*Error near IL_000e: Unknown opcode: 0xE7*/;
		}

		public MapGroupStageCount(JsonData jsonData)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0006: Unknown opcode: 0xFD*/;
		}

		public unsafe JsonData ToJsonData()
		{
			_ = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: Unknown opcode: 0xCF*/;
		}
	}

	public enum BootConfigLoadType
	{
		None = 0,
		Prologue = 1,
		PrologueBattleLevel = 2,
		Mainline = 10,
		RegionBoss = 23,
		WeeklyCopies = 25,
		BattleTestBedComboClip = 34,
		TravelerDuel = 40,
		TravelerDuelEditor = 41,
		DailyInstance_Formal = 51,
		DailyInstance_BootConfig = 52,
		InfinityTower_Fromal = 61,
		InfinityTower_BootConfig = 62,
		EquipmentInstance_Formal = 71,
		EquipmentInstance_BootConfig = 72,
		StarTower_Formal = 80,
		StarTower_ByRandom = 81,
		StarTower_ByFixedId = 82,
		StarTower_ByFixedId_ThroughBootConfig = 83,
		StarTower_Limitless = 85,
		VampireSurvivor_Fromal = 90,
		VampireSurvivor_BootConfig = 91,
		SceneView = 99,
		ScoreBoss_Fromal = 100,
		ScoreBoss_BootConfig = 101,
		SkillInstance_Formal = 111,
		SkillInstance_BootConfig = 112,
		DynamicLevel = 120,
		AutoBattleBalance_BootConfig = 130,
		ActivityLevelsInstance_Formal = 140,
		TowerDefense = 150,
		BreakOut_BootConfig = 160,
		ActivityStoryLevels = 170
	}

	public BootConfigLoadType loadType;

	public string id;

	protected int levelID;

	protected int battleLv;

	public int starTowerStageID;

	public string mapId;

	[ReadOnly]
	public const int DefaultTiledColorMapSize = 1024;

	[ReadOnly]
	public int tiledColorMapSize;

	public int floor;

	[HideInInspector]
	public bool isHalfVampireBattleMode;

	[HideInInspector]
	public List<int> vampireSpecialEnemySet;

	[HideInInspector]
	public List<int> vampireTreasureSet;

	[HideInInspector]
	public List<VampireDropData> vampireDropList;

	public bool isVampireFirstHalf;

	public int monsterLevel;

	[HideInInspector]
	public bool isBattleEnd;

	[HideInInspector]
	public bool isFinalLevelFloor;

	public int levelDifficultLv;

	public Lua2CSharpInfo_RoguelikeChestInfo[] rogueTreasureBoxInfos;

	public Lua2CSharpInfo_FixedRoguelike fixedRoguelikeInfo;

	[ReadOnly]
	[HideInInspector]
	public int[] mainlineOpenedTreasureBoxs;

	[HideInInspector]
	public List<FixedRoguelikeRoomData> fixedRoguelikeRoomData;

	[HideInInspector]
	public RandomMonsterSpawnWaveGizmo.RdmMonsterSpawnInfo rogRdmMonsterSpawnInfo;

	[SerializeField]
	[HideInInspector]
	public string strRdmMonsterSpawnInfo;

	[HideInInspector]
	public bool isThreePlayer;

	[HideInInspector]
	public Vector3 revivalPoint;

	[HideInInspector]
	public bool isStarTowerPrologue;

	[HideInInspector]
	public List<string> btnNames;

	[HideInInspector]
	public int dropEntityGroupId;

	[HideInInspector]
	public FP dropEntityRate;

	[HideInInspector]
	public int dropMaxNum;

	public int dynamicLevelType;

	public string[] enterDynamicLevelParams;

	public HotfixEnum.elementType autoBattleBalanceEET;

	public AutoBattleBalanceConfig autoBattleBalanceConfig;

	[HideInInspector]
	public FP balanceMainPlayHPPre;

	[HideInInspector]
	public int balanceTeamIndex;

	[ReadOnly]
	public int[] starTowerDropInfo;

	public StarTowerCombo starTowerCombo;

	public StarTowerFloorSet starTowerFloorSet;

	public StarTowerScenePrefab starTowerScenePrefab;

	[HideInInspector]
	public int nextRoomType;

	public string dmgRecordId;

	public string dynamicBGM;

	public string dynamicLeaveMusicEvent;

	public string dynamicSceneName;

	public float dynamicParam;

	[HideInInspector]
	public float levelRunningTime;

	public State[] bgmState;

	public MainlineFloor mainlineFloorData
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		protected set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public RegionBossFloor regionBossFloor
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		protected set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public StarTowerStage starTowerStage
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		protected set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public StarTowerFloor starTowerFloor
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		protected set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public StarTowerMap starTowerMap
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		protected set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public RegionBossLevel regionBossLevel
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		protected set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public bool isInfinityContinueBattle
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public HotfixEnum.worldLevelType levelType
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public bool viewSceneMode
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		private set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public bool sendBattleEndMsg
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		private set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public bool gmOrderLevel
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		private set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public string starTowerScenePath
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		protected set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public string starTowerConfigPath
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		protected set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public string starTowerConfigExtension
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		protected set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public bool isRaceStarTower
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected I4, but got Unknown
			switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
			{
			default:
				/*Error: End of method reached without returning.*/;
			case 0:
				/*Error: Invalid branch target*/;
			case 1:
				/*Error: Invalid branch target*/;
			case 2:
				/*Error: Invalid branch target*/;
			case 3:
				/*Error: Invalid branch target*/;
			case 4:
				/*Error: Invalid branch target*/;
			}
		}
	}

	public unsafe AdventureModuleLevelLoadParams()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0003: Stack underflow*// (nint)(*(IntPtr*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public unsafe AdventureModuleLevelLoadParams(string id)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0003: Stack underflow*// (nint)(*(IntPtr*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public unsafe AdventureModuleLevelLoadParams(int levelID, int battleLv)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0003: Stack underflow*// (nint)(*(IntPtr*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public void GenerateViewSceneData(HotfixEnum.worldLevelType levelType, bool viewSceneMode = true, int starTowerFloorSetId = 0, int prefabID = 0, string prefabExtension = "", int playType = 0, bool sceneDoMir = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) != 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: ldarga 160 (out-of-bounds)*/;
		/*Error near IL_0008: Invalid metadata token*/;
	}

	public MainlineFloor Mainline_GenerateFloorData()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public StarTowerFloor StarTower_GenerateFloorData()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public void StarTower_GenerateMapData_ViewSceneMode(int mapID, int floorSetId, int prefabID = 0, string prefabExtension = "", int playType = 0, bool sceneDoMir = false)
	{
		//Discarded unreachable code: IL_010b
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	public StarTowerMap StarTower_GenerateMapData(int mapID)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public void StarTower_GenerateMapData(Lua2CSharpInfo_FixedRoguelike info)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (ulong)/*Error near IL_0007: Stack underflow*/ >> 1791030788;
			/*Error near IL_000e: Unknown opcode: 0xCD*/;
		}
	}

	private void GenerateStarTowerFloor(int floorID = 0, int appointedGameplayType = 0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	private void GenerateScenePrefab(int prefabId = 0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	private void GenerateMapConfig(bool reconnect = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/< 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0007: starg 40 (out-of-bounds)*/;
			_ = /*Error near IL_000b: Stack underflow*/- /*Error near IL_0009: ldloc 0 (out-of-bounds)*/;
		}
	}

	public RegionBossFloor RegionBoss_GenerateFloorData()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public RegionBossLevel RegionBoss_GenerateLvData(int regionBosslvId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	private void playBgm()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
		default:
			/*Error: End of method reached without returning.*/;
		case 0:
			/*Error: Invalid branch target*/;
		case 1:
			/*Error: Invalid branch target*/;
		case 2:
			/*Error: Invalid branch target*/;
		case 3:
			/*Error: Invalid branch target*/;
		case 4:
			/*Error: Invalid branch target*/;
		case 5:
			/*Error: Invalid branch target*/;
		case 6:
			/*Error: Invalid branch target*/;
		case 7:
			/*Error: Invalid branch target*/;
		case 8:
			/*Error: Invalid branch target*/;
		case 9:
			/*Error: Invalid branch target*/;
		}
	}

	private void SetFullEnergy()
	{
		//Discarded unreachable code: IL_000b, IL_0032
		//IL_003d: Invalid comparison between Unknown and I
		/*Error: Unknown opcode: 0xFD*/;
	}

	private void BalanceNextLv()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}
}
