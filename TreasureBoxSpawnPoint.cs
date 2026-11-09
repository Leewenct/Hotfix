using System;
using System.Runtime.CompilerServices;
using TrueSync;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TreasureBoxSpawnPoint : BaseSpawnPointGizmo
{
	public enum TreasureBoxLevel
	{
		Low,
		Medium,
		High
	}

	public enum TreasureBoxRefType
	{
		Fixed,
		Random
	}

	public enum TreasureBoxRewardType
	{
		Basic,
		Extra
	}

	public class TreasureBoxSpawnInfo
	{
		public int indexOfMainline;

		public bool isRdmRef;

		public TreasureBoxLevel boxLv;

		public long uniqueID;

		public string name;

		public InteractiveManager.interactiveState interactiveState;

		public TreasureBoxRewardType reType;

		public int prizeType;

		public int x;

		public int y;
	}

	public HotfixEnum.worldLevelType levelType;

	public int boxID;

	public TreasureBoxLevel boxLevel;

	public TreasureBoxRefType boxRefType;

	public TreasureBoxRewardType rewardType;

	public int boxIndex;

	[HideInInspector]
	public int boxPrizeType;

	[HideInInspector]
	public int boxThemeId;

	[HideInInspector]
	public TSVector2 randomCenterPos;

	[HideInInspector]
	public FP RandomRotation;

	[HideInInspector]
	public FP RandomAngle;

	public bool isTriggerActived;

	[ReadOnly]
	public float refRng;

	public bool isRandomPosition;

	private bool hasRandomPosition;

	protected AdventureLevelObjPoolMgr.PoolObj spawnPoolObj;

	protected TreasureBoxSpawnInfo spawnInfo;

	protected InteractiveBox spawnBox;

	public long spawnBoxUniqueID
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

	public bool isTreasureBoxOpened
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

	protected override void OnActive()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected override void OnDeactive()
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	private void OnLevelEnd(IEvent ievent)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xE2*/;
		}
	}

	private void TreasureBoxDespawn(IEvent ievent)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 204 (out-of-bounds)*/;
			_ = -1;
			/*Error near IL_0004: Unknown opcode: 0xEF*/;
		}
	}

	public void InitTreasureInfo(int id, int index)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}

	public override void EnableSpawnLogic()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		Scene val = (Scene)checked((/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) * 0);
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	private void Update()
	{
	}

	public unsafe override void ExecuteSpawnLogic(AdventureActor summoner = null)
	{
		_ = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xF9*/;
	}

	public override void UpdateSpawnLogic()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		((IntPtr[])/*Error near IL_0003: Stack underflow*/)[checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/)] = (IntPtr)0;
		/*Error near IL_0003: Invalid field token*/;
	}

	protected TSVector2 GetRandomPosition()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected I4, but got Unknown
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
		case 10:
			/*Error: Invalid branch target*/;
		case 11:
			/*Error: Invalid branch target*/;
		case 12:
			/*Error: Invalid branch target*/;
		case 13:
			/*Error: Invalid branch target*/;
		case 14:
			/*Error: Invalid branch target*/;
		case 15:
			/*Error: Invalid branch target*/;
		case 16:
			/*Error: Invalid branch target*/;
		case 17:
			/*Error: Invalid branch target*/;
		case 18:
			/*Error: Invalid branch target*/;
		case 19:
			/*Error: Invalid branch target*/;
		case 20:
			/*Error: Invalid branch target*/;
		case 21:
			/*Error: Invalid branch target*/;
		case 22:
			/*Error: Invalid branch target*/;
		case 23:
			/*Error: Invalid branch target*/;
		case 24:
			/*Error: Invalid branch target*/;
		case 25:
			/*Error: Invalid branch target*/;
		case 26:
			/*Error: Invalid branch target*/;
		case 27:
			/*Error: Invalid branch target*/;
		case 28:
			/*Error: Invalid branch target*/;
		case 29:
			/*Error: Invalid branch target*/;
		case 30:
			/*Error: Invalid branch target*/;
		case 31:
			/*Error: Invalid branch target*/;
		case 32:
			/*Error: Invalid branch target*/;
		case 33:
			/*Error: Invalid branch target*/;
		case 34:
			/*Error: Invalid branch target*/;
		case 35:
			/*Error: Invalid branch target*/;
		case 36:
			/*Error: Invalid branch target*/;
		case 37:
			/*Error: Invalid branch target*/;
		case 38:
			/*Error: Invalid branch target*/;
		case 39:
			/*Error: Invalid branch target*/;
		case 40:
			/*Error: Invalid branch target*/;
		case 41:
			/*Error: Invalid branch target*/;
		case 42:
			/*Error: Invalid branch target*/;
		case 43:
			/*Error: Invalid branch target*/;
		case 44:
			/*Error: Invalid branch target*/;
		case 45:
			/*Error: Invalid branch target*/;
		case 46:
			/*Error: Invalid branch target*/;
		case 47:
			/*Error: Invalid branch target*/;
		case 48:
			/*Error: Invalid branch target*/;
		case 49:
			/*Error: Invalid branch target*/;
		case 50:
			/*Error: Invalid branch target*/;
		case 51:
			/*Error: Invalid branch target*/;
		case 52:
			/*Error: Invalid branch target*/;
		case 53:
			/*Error: Invalid branch target*/;
		case 54:
			/*Error: Invalid branch target*/;
		case 55:
			/*Error: Invalid branch target*/;
		case 56:
			/*Error: Invalid branch target*/;
		case 57:
			/*Error: Invalid branch target*/;
		case 58:
			/*Error: Invalid branch target*/;
		case 59:
			/*Error: Invalid branch target*/;
		case 60:
			/*Error: Invalid branch target*/;
		case 61:
			/*Error: Invalid branch target*/;
		case 62:
			/*Error: Invalid branch target*/;
		case 63:
			/*Error: Invalid branch target*/;
		case 64:
			/*Error: Invalid branch target*/;
		case 65:
			/*Error: Invalid branch target*/;
		case 66:
			/*Error: Invalid branch target*/;
		case 67:
			/*Error: Invalid branch target*/;
		case 68:
			/*Error: Invalid branch target*/;
		case 69:
			/*Error: Invalid branch target*/;
		case 70:
			/*Error: Invalid branch target*/;
		case 71:
			/*Error: Invalid branch target*/;
		case 72:
			/*Error: Invalid branch target*/;
		case 73:
			/*Error: Invalid branch target*/;
		case 74:
			/*Error: Invalid branch target*/;
		case 75:
			/*Error: Invalid branch target*/;
		case 76:
			/*Error: Invalid branch target*/;
		case 77:
			/*Error: Invalid branch target*/;
		case 78:
			/*Error: Invalid branch target*/;
		case 79:
			/*Error: Invalid branch target*/;
		case 80:
			/*Error: Invalid branch target*/;
		case 81:
			/*Error: Invalid branch target*/;
		case 82:
			/*Error: Invalid branch target*/;
		case 83:
			/*Error: Invalid branch target*/;
		case 84:
			/*Error: Invalid branch target*/;
		case 85:
			/*Error: Invalid branch target*/;
		case 86:
			/*Error: Invalid branch target*/;
		case 87:
			/*Error: Invalid branch target*/;
		}
	}

	protected ActorSpawnInfo GetMonsterSpawnInfo(bool callbackImmediately = false)
	{
		/*Error: Unknown opcode: 0xE7*/;
	}

	protected void MonsterDied(IEvent ievent)
	{
		/*Error: Unknown opcode: 0xFD*/;
	}

	public void Recycle()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected I4, but got Unknown
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
		}
	}

	public void Despawn()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	public TreasureBoxSpawnPoint()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid calli metadata token*/;
		}
	}
}
