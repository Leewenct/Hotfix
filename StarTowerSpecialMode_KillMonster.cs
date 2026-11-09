using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Nova.Hotfix;
using TrueSync;

public class StarTowerSpecialMode_KillMonster : StarTowerSpecialMode
{
	private StarTowerFloor fixedRoguelikeFloor;

	private int totalTime;

	private FP timeing;

	private bool isPause;

	private int delayTime;

	private FP delayTimeing;

	private bool isDelayEnd;

	private List<long> spawnedMonster;

	public override void EntryRoom(Action<HotfixEnum.levelState> callback)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (nuint)/*Error near IL_0007: Stack underflow*/ + 1690396461;
		}
	}

	public override void Complete(HotfixEnum.levelState state)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = ((int[])/*Error near IL_0009: Stack underflow*/)[(sbyte)(nuint)/*Error near IL_0007: Stack underflow*/];
			/*Error near IL_000a: Unknown opcode: 0xAF*/;
		}
	}

	public override void ActiveEvent()
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
			this = (StarTowerSpecialMode_KillMonster)/*Error near IL_0009: Stack underflow*/;
			_ = /*Error near IL_000b: Stack underflow*/+ /*Error near IL_0009: ldarg 2 (out-of-bounds)*/;
			/*Error near IL_000b: Unknown opcode: 0xE4*/;
		}
	}

	private void MonsterDied(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0002: Invalid metadata token*/;
	}

	private unsafe void MonsterSpawn(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = (short)(*(int*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0003: Invalid field token*/;
	}

	public unsafe override void Pause()
	{
		*(sbyte*)(nint)/*Error near IL_0002: Stack underflow*/ = (sbyte)checked((nuint)/*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xF7*/;
	}

	public unsafe override void Resume()
	{
		System.Runtime.CompilerServices.Unsafe.Read<object>((void*)checked((nuint)/*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0002: Unknown opcode: 0xF7*/;
	}

	public override void LeaveRoom()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		}
	}

	public StarTowerSpecialMode_KillMonster()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}
}
