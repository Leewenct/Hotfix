using System.Runtime.CompilerServices;
using TrueSync;
using UnityEngine;

[AddComponentMenu("游戏/冒险模块/武器组件/武器通用_结束时召唤怪物组件(目前仅炸弹可用)")]
[DisallowMultipleComponent]
public class WeaponComponent_SummonWhenFinish : LogicMonoComponent, IBombComponent
{
	public int monsterId;

	public bool useMonsterTeamMate;

	public int monsterTeamMateIndex;

	public SummonAttrType summonAttrType;

	public SummonRelation summonRelation;

	public int attrPercent;

	public FP leftTime;

	public int maxCount;

	public SummonDirType summonDirType;

	protected AdventureWeapon _context;

	protected SummonCfg summonCfg;

	public bool KeepAlive
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

	public unsafe void Setup()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected F8, but got I
		if (/*Error near IL_0006: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		*(double*)(nint)/*Error near IL_0008: Stack underflow*/ = (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/);
		/*Error near IL_0008: Unknown opcode: 0x77*/;
	}

	public unsafe void Reset(LogicEntity owner = null, TSVector2 position = default(TSVector2), FP positionY = default(FP), TSVector2 direction = default(TSVector2), LogicEntity target = null, TSVector2 targetPosition = default(TSVector2), FP targetPositionY = default(FP))
	{
		*(sbyte*)(nint)/*Error near IL_0002: Stack underflow*/ = (sbyte)checked((nuint)/*Error near IL_0001: Stack underflow*/);
		((object[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (object)/*Error near IL_0003: Stack underflow*/;
		/*Error near IL_0003: Unknown opcode: 0xF7*/;
	}

	public void Finish()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	private TSVector2 GetSummonDirection(TSVector2 summonPosition)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected I4, but got Unknown
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
		}
	}

	public override void OnDeactive()
	{
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0002: Unknown opcode: 0xCD*/;
	}

	public WeaponComponent_SummonWhenFinish()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_000d: Stack underflow*/ < checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/+ 3170605112382897711L))
		{
			/*Error: Invalid branch target*/;
		}
		_ = /*Error near IL_000e: Stack underflow*/>> (int)/*Error near IL_000e: Stack underflow*/;
		/*Error near IL_000e: Unknown opcode: 0xEF*/;
	}
}
