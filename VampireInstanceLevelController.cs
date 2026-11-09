using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Nova.Hotfix;
using TrueSync;

public class VampireInstanceLevelController : AdventureLevelController
{
	protected const string ZoomFreezeKey = "ZoomFreeze";

	protected const string ZoomDurationTimeKey = "ZoomInDurationTime";

	protected float _zoomFreeze;

	protected float _zoomDurationTime;

	protected VampireFloor vampireFloorData;

	protected VampireMap vampireMapData;

	protected bool isStartTime;

	protected FP timeing;

	protected int totalTime;

	protected bool isSettlement;

	protected int poolId;

	protected VampireMonsterSpawnWaveGizmo vmSpawnWaveGizmo;

	protected bool isFirstHalfEnd;

	public unsafe override void Initialize(ExtraLevelInfo extraLevelInfo, EventDispatcher eventDispatcher, Action<AdventureLevelState> levelStatusChanged)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected native int or pointer, but got Obj
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		((IntPtr[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/] = (IntPtr)/*Error near IL_0007: Stack underflow*/;
		string text = default;
		((int[])/*Error near IL_000f: Stack underflow*/)[/*Error near IL_000f: Stack underflow*/] = (sbyte)(int)(uint)(/*Error near IL_000b: Stack underflow*/ + System.Runtime.CompilerServices.Unsafe.Read<object>((void*)(nint)text));
		checked
		{
			if (/*Error near IL_0016: Stack underflow*/ <= /*Error near IL_0011: Stack underflow*/* *unchecked((ushort*)(nint)/*Error near IL_0010: Stack underflow*/))
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0016: Not a type handle*/;
		}
	}

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
		//IL_0011: Invalid comparison between Unknown and I4
		if ((long)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/) > 5357313835286072314L)
		{
			/*Error: Invalid branch target*/;
		}
		if ((int)/*Error near IL_0013: Stack underflow*/ < (int)checked((ushort)unchecked((uint)checked((sbyte)/*Error near IL_0010: Stack underflow*/))))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0013: ldarg 3 (out-of-bounds)*/;
		/*Error near IL_0014: Unknown opcode: 0xE6*/;
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

	public override void LevelStart(Action callback = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (nuint)/*Error near IL_0007: Stack underflow*/;
			_ = -2034370044;
			/*Error near IL_000d: Unknown opcode: 0x77*/;
		}
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
			_ = (nuint)/*Error near IL_0007: Stack underflow*/ + 1691424825;
		}
	}

	public unsafe override void LevelEnd()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected F4, but got I4
		*(float*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) = 0f;
		MonsterAdventureActor monsterAdventureActor = (MonsterAdventureActor)/*Error near IL_0004: Stack underflow*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public override void LevelFinish()
	{
		/*Error: Invalid field token*/;
	}

	private void OnPlayerDied(IEvent ievent)
	{
		/*Error: Unknown opcode: 0xF0*/;
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

	private unsafe void FirstHalfSettlement(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*OpCode not supported: DebugBreak*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	protected void LevelStateChangedCallback(HotfixEnum.levelState levelState)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected I4, but got Unknown
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
		}
	}

	protected void LevelSuccessCallBack()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	protected void LevelFailedCallBack(bool isPlayerDied)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldloca 211 (out-of-bounds)*/;
			/*OpCode not supported: DebugBreak*/;
			/*Error near IL_0004: Unknown opcode: 0xFB*/;
		}
	}

	private void GMSetVampireWaveNext(IEvent ievent)
	{
	}

	public VampireInstanceLevelController()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}
}
