using System;
using System.Collections.Generic;
using Nova.Hotfix;
using TrueSync;

public class TraceHuntLevelController : AdventureLevelController
{
	private int totalTime;

	private int levelTotalTime;

	private FP timeing;

	protected bool isTestPresetTeam;

	protected const string ZoomFreezeKey = "ZoomFreeze";

	protected const string ZoomDurationTimeKey = "ZoomInDurationTime";

	protected float _zoomFreeze;

	protected float _zoomDurationTime;

	protected TraceHuntFloor floorData;

	protected TraceHuntFloorGroup floorGroupData;

	protected bool isStartTime;

	protected bool isSettlement;

	protected List<TraceHuntDropSpawnGizmo> dropSpawnGizmos;

	protected HashSet<long> _aliveDropIds;

	protected FP _dropRefreshTimer;

	protected FP _dropRefreshInterval;

	protected int _lastDropIndex;

	protected const int DropMaxCount = 2;

	protected const int DefaultDropRefreshInterval = 8;

	public override void Load(AdventureModuleLevelLoadParams param = null, Action callback = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Invalid metadata token*/;
	}

	protected override void LevelLoadComplete(string sceneName)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I8
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		if ((long)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/) > 5357313835286072314L)
		{
			/*Error: Invalid branch target*/;
		}
		((float[])/*Error near IL_0010: Stack underflow*/)[/*Error near IL_0010: Stack underflow*/] = (float)/*Error near IL_0010: Stack underflow*/;
		checked
		{
			_ = /*Error near IL_0011: Stack underflow*/- /*Error near IL_0011: Stack underflow*/;
			_ = 0;
			/*Error near IL_0012: Invalid metadata token*/;
		}
	}

	public override void InitSpawnPoints()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xCF*/;
		}
	}

	public override void HandleSpawnGizmos()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	protected override void HandleTreasureBoxSpawnPoints()
	{
	}

	public override void LevelStart(Action callback)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (nuint)/*Error near IL_0007: Stack underflow*/;
			_ = -2052916732;
			/*Error near IL_000d: Unknown opcode: 0x77*/;
		}
	}

	private unsafe void OnLevelMaxStar(IEvent evt)
	{
		//IL_0003: Expected Obj, but got I8
		((object[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = *(long*)checked((nuint)/*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0003: Read out of bounds.*/;
	}

	public override void UpdateLogic(FP logicDeltaTime)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (nuint)/*Error near IL_0007: Stack underflow*/ + 1691412268;
		}
	}

	protected void TrySpawnDrop()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected I4, but got Unknown
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
		}
	}

	protected unsafe void OnDropFinish(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Invalid metadata token*/;
	}

	public unsafe override void LevelEnd()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected F4, but got I4
		*(float*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) = 0f;
		/*Error near IL_0003: stloc 1 (out-of-bounds)*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	private unsafe void OnPlayerDied(IEvent ievent)
	{
		*(sbyte*)(nint)/*Error near IL_0002: Stack underflow*/ = (sbyte)checked((nuint)/*Error near IL_0001: Stack underflow*/);
		((object[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (object)/*Error near IL_0003: Stack underflow*/;
		/*Error near IL_0003: Read out of bounds.*/;
	}

	private void StartTiming(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid calli metadata token*/;
		}
	}

	private void MonsterDeclareDeath(IEvent evt)
	{
		/*OpCode not supported: DebugBreak*/;
		/*Error near IL_0001: Unknown opcode: 0xE7*/;
	}

	private unsafe void MonsterSpawnBefore(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(int*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0003: Invalid field token*/;
	}

	private unsafe void MonsterSpawn(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = (short)(*(int*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0003: Invalid field token*/;
	}

	protected unsafe void LevelStateChangedCall(HotfixEnum.levelState levelState)
	{
		//IL_0002: Expected F8, but got I4
		((double[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0002: Unknown opcode: 0xFE80*/;
	}

	public override List<BaseSpawnPointGizmo> GetWaves(string waveName, int x = -1, int y = -1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xC9*/;
		}
	}

	public override List<BaseSpawnPointGizmo> GetPlans(string planName, int x = -1, int y = -1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xC9*/;
		}
	}

	public override List<BaseSpawnPointGizmo> GetGroups(string groupName, int x = -1, int y = -1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xC9*/;
		}
	}

	public TraceHuntLevelController()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/+ (ushort)483116350u;
			/*Error near IL_0008: Invalid metadata token*/;
		}
	}
}
