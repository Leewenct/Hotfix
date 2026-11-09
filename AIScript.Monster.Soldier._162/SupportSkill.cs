using System.Collections.Generic;
using TrueSync;

namespace AIScript.Monster.Soldier._162;

public class SupportSkill : SkillAdvancedBase
{
	private const string comboTag = "SupportSkill";

	private const string eventName_Area = "Area";

	private const string areaEffectKey = "AreaEffect";

	private const int loopTimes = 4;

	private const int spawnCountPerArea = 3;

	private static readonly FP spawnRadius;

	private const string eventName_Fire_Potential2 = "162P23JianQi";

	private static readonly List<TSVector2> fireDirections_Potential2;

	private static readonly List<string> bulletKeyList_Potential2;

	private static readonly FP bulletRange_Potential2;

	private const int extraLoopTimes_Potential3 = 2;

	private const string bulletKey_Potential3 = "Bullet_SupSkill_JianQi_Big_P2_Soldier";

	private int _loopTimes;

	private int _totalLoopTimes;

	private int _potentialLv;

	protected override void OnSkillEnable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		((short[])/*Error near IL_0003: Stack underflow*/)[checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/)] = 0;
		_ = /*Error near IL_0004: Stack underflow*/+ /*Error near IL_0004: Stack underflow*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	protected override void OnSkillDisable()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		_ = /*Error near IL_0004: Stack underflow*/>> (int)(ushort)/*Error near IL_0003: Stack underflow*/;
		/*Error near IL_0005: ldloc 0 (out-of-bounds)*/;
		/*Error near IL_0006: Unknown opcode: 0xB0*/;
	}

	public unsafe void OnStart()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(long*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xEB*/;
	}

	private void OnComboLoop()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0007: Not a type handle*/;
	}

	private unsafe void OnCustomEvent(string eventName)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0003: Stack underflow*/^ *(long*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0003: Unknown opcode: 0xB0*/;
	}

	private void OnAreaEvent()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected I4, but got Unknown
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
		}
	}

	private unsafe void OnFireEvent_Potential2()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected I4, but got Unknown
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		((int[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = /*Error near IL_0002: Stack underflow*/>> (int)/*Error near IL_0002: Stack underflow*/;
		/*Error near IL_0004: Unknown opcode: 0xE8*/;
	}

	private static TSVector2 GetScatterPoint(TSVector2 center, int index, int count)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid calli metadata token*/;
		}
	}

	private void OnFinish()
	{
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	private void OnInterrupt()
	{
		/*Error: Read out of bounds.*/;
	}

	public SupportSkill()
	{
		/*Error: Invalid field token*/;
	}

	static SupportSkill()
	{
		/*Error: Unknown opcode: 0xEE*/;
	}
}
