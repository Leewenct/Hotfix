using TrueSync;

namespace AIScript.Character._10801;

public class ParallelScript_MainControl : ParallelScript
{
	private static readonly int damageTag_NormalAttack;

	private static readonly int damageTag_DefaultNormalAttack;

	private static readonly int damageTag_SpecialNormalAttack;

	private static readonly int damageTag_MainControl;

	private const int perkId_3 = 510803;

	private const int skillTotalSectionAmount_3 = 5;

	private const int perkId_5 = 510805;

	private const int additionalAttrId_5 = 10850501;

	private const int perkId_6 = 510806;

	private readonly FP cd_6;

	private const int perkId_7 = 510807;

	private const int triggerCritTimes_7 = 10;

	private const int buffId_7 = 10850711;

	private const int perkId_8 = 510808;

	private const int buffId_8 = 10850801;

	private const int perkId_10 = 510810;

	private const int triggerTimes_10 = 6;

	private const int parameterId_10 = 10851001;

	private const int additionalAttrId_10 = 10851001;

	private const int perkId_11 = 510811;

	private const int parameterId_11 = 10851111;

	private const int additionalAttrId_11 = 10851101;

	private const int perkId_12 = 510812;

	private readonly FP triggerDistance_12;

	private const int additionalAttrId_12 = 10851201;

	private const int perkId_13 = 510813;

	private const int buffId_13 = 10851301;

	private int _additionalAttrCount_5;

	private FP _lastTriggerTime_6;

	private int _triggerCritTimes_7;

	private int _triggerTimes_10;

	public override void OnEnable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = ((long[])/*Error near IL_0004: Stack underflow*/)[checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/- 0)];
		/*Error near IL_0004: Unknown opcode: 0xED*/;
	}

	protected override void OnCastNormalSkill(AdventureActorCastSkillEvent castSkillEvent)
	{
		/*Error: Unknown opcode: 0xF0*/;
	}

	private unsafe void OnNormalAttackFinish(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: ldloc 2 (out-of-bounds)*/;
		/*OpCode not supported: DebugBreak*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	protected override void OnCastSkill(AdventureActorCastSkillEvent castSkillEvent)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (nuint)/*Error near IL_0007: Stack underflow*/ + 1678767227;
		}
	}

	protected override void OnSelfAttacked(AdventureActorReceiveAttackEvent attackEvent)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((nint)/*Error near IL_0009: Stack underflow*/ <= (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/))
		{
			/*Error near IL_0009: Unknown opcode: 0xEB*/;
		}
		/*Error near IL_007e: Unknown opcode: 0xE3*/;
	}

	protected override void OnBeforeSelfHit(AdventureActorReceiveDamageBeforeHitEvent beforeHitEvent)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((nint)/*Error near IL_0009: Stack underflow*/ <= (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/))
		{
			MonsterAdventureActor monsterAdventureActor = (MonsterAdventureActor)/*Error near IL_000a: Stack underflow*/;
			/*Error near IL_000a: Unknown opcode: 0xBD*/;
		}
		/*Error near IL_007e: Unknown opcode: 0xC9*/;
	}

	protected override void OnSelfDamaged(AdventureActorReceiveDamageEvent damageEvent)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (sbyte)(nuint)/*Error near IL_0007: Stack underflow*/;
			/*Error near IL_0008: Invalid metadata token*/;
		}
	}

	protected override void OnTriggerFireMark()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xE8*/;
		}
	}

	private void Clear()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	public override void OnDisable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xEA*/;
		}
	}

	public ParallelScript_MainControl()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0x24*/;
		}
	}

	unsafe static ParallelScript_MainControl()
	{
		_ = *(byte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xBC*/;
	}
}
