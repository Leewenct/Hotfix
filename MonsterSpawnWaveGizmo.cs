using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class MonsterSpawnWaveGizmo : BaseSpawnPointGizmo
{
	public enum WaveType
	{
		Default,
		Goblin,
		Trap,
		QuitSettlement
	}

	public bool isTriggerActived;

	public WaveType waveType;

	private BaseSpawnPointGizmo enabledGizmo;

	private Action childMonsterDiedCallback;

	public bool elitFlag
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

	public override void EnableSpawnLogic()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected I4, but got Unknown
		int num = checked((/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) * 0);
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public override bool IsAllActivedAndDied()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
		default:
			/*Error: End of method reached without returning.*/;
		case 0:
			/*Error: Invalid branch target*/;
		case 1:
			/*Error: Invalid branch target*/;
		}
	}

	public override bool IsAllActivedAndDied_NoSummons()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
		default:
			/*Error: End of method reached without returning.*/;
		case 0:
			/*Error: Invalid branch target*/;
		case 1:
			/*Error: Invalid branch target*/;
		}
	}

	public override List<long> GetSpawnedEntities()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected Obj, but got I
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			List<long> list = (List<long>)(nint)0;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public override int DiedMonsterCount()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) * 0;
			/*Error near IL_0003: stloc 0 (out-of-bounds)*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public override int RemindMonsterCount()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) * 0;
			/*Error near IL_0003: stloc 0 (out-of-bounds)*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public MonsterSpawnWaveGizmo()
	{
		/*Error: Invalid field token*/;
	}
}
