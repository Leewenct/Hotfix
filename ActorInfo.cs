using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Nova.Hotfix;
using TrueSync;
using UnityEngine;

public class ActorInfo : LogicComponent
{
	private AttributeList attributeList;

	private AdventureActor _actor;

	public Dictionary<int, FDP> attributeWithElementOrDamageTypeDict;

	public HotfixEnum.AssistOnStageType originAssistSkillOnStageType;

	public HotfixEnum.AssistOnStageType assistSkillOnStageType;

	public HotfixEnum.AssistOnStageOrientation originAssistSkillOnStageOrientation;

	public HotfixEnum.AssistOnStageOrientation assistSkillOnStageOrientation;

	public FP originAssistSkillAngle;

	public FP assistSkillAngle;

	public FP originAssistSkillRadius;

	public FP assistSkillRadius;

	public HotfixEnum.AssistOnStageType originAssistUltraOnStageType;

	public HotfixEnum.AssistOnStageType assistUltraOnStageType;

	public HotfixEnum.AssistOnStageOrientation originAssistUltraOnStageOrientation;

	public HotfixEnum.AssistOnStageOrientation assistUltraOnStageOrientation;

	public FP originAssistUltimateAngle;

	public FP assistUltimateAngle;

	public FP originAssistUltimateRadius;

	public FP assistUltimateRadius;

	public FP skillSemiAutoRng;

	public FP ultimateSemiAutoRng;

	[Space]
	public FP transSpdScale;

	[Space]
	public FP transSpd;

	[Space]
	public bool dodgeToRushAcceleration;

	protected HotfixEnum.actorMovType _moveType;

	protected FP _runSpeed;

	public bool fastSpeedMode;

	public FP fastRunSpeed;

	protected FP _walkSpeed;

	protected FP _walktoRunDuration;

	protected FP _moveAcceleration;

	protected FP _moveDeceleration;

	protected FP _moveRotationSpeed;

	protected FP _skillRotationSpeed;

	protected FP _attackSpeed;

	protected FP _shootDeviation;

	protected int _factionID;

	[Space]
	public FP runAnimationSpd;

	[Space]
	public FP spRunAnimationSpd;

	[Space]
	public FP walkAnimationSpd;

	[Space]
	public FP moveDirChangeSmoothTime;

	[Space]
	public List<FP> hurtFxRadialOffsets;

	[Space]
	public FP supCharge;

	[Space]
	public bool IsTriggerTrap;

	public FP skillCDMaxPercentAmend;

	public FP skillCDMaxAmend;

	public FP dodgeCDMaxPercentAmend;

	public FP dodgeCDMaxAmend;

	public FP ultraCDMaxPercentAmend;

	public FP ultraCDMaxAmend;

	[HideInInspector]
	public FP ComboSpdMultiplier;

	public unsafe FDP atk
	{
		get
		{
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			*(sbyte*)(nint)/*Error near IL_0002: Stack underflow*/ = (sbyte)checked((nuint)/*Error near IL_0001: Stack underflow*/);
			((object[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (object)/*Error near IL_0003: Stack underflow*/;
			if (checked(/*Error near IL_0004: Stack underflow*/ * /*Error near IL_0004: Stack underflow*/) == 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0005: Read out of bounds.*/;
		}
	}

	public unsafe FDP def
	{
		get
		{
			//IL_0003: Expected Obj, but got I8
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			((object[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = *(long*)checked((nuint)/*Error near IL_0001: Stack underflow*/);
			if (checked(/*Error near IL_0004: Stack underflow*/ * /*Error near IL_0004: Stack underflow*/) == 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0005: Read out of bounds.*/;
		}
	}

	public unsafe FDP originHitRate
	{
		get
		{
			//IL_0003: Expected Obj, but got I4
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			((object[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = *(short*)checked((nuint)/*Error near IL_0001: Stack underflow*/);
			if (checked(/*Error near IL_0004: Stack underflow*/ * /*Error near IL_0004: Stack underflow*/) == 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0005: Read out of bounds.*/;
		}
		set
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Expected I4, but got Unknown
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
			}
		}
	}

	public unsafe FDP hitRate
	{
		get
		{
			//IL_0003: Expected Obj, but got I4
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			((object[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = *(short*)checked((nuint)/*Error near IL_0001: Stack underflow*/);
			if (checked(/*Error near IL_0004: Stack underflow*/ * /*Error near IL_0004: Stack underflow*/) == 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0005: Read out of bounds.*/;
		}
	}

	public unsafe FDP evd
	{
		get
		{
			//IL_0003: Expected Obj, but got I4
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			((object[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = *(int*)checked((nuint)/*Error near IL_0001: Stack underflow*/);
			if (checked(/*Error near IL_0004: Stack underflow*/ * /*Error near IL_0004: Stack underflow*/) == 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0005: Read out of bounds.*/;
		}
	}

	public FDP critRate
	{
		get
		{
			//IL_0001: Invalid comparison between Unknown and I
			if ((nint)/*Error near IL_0006: Stack underflow*/ < (nint)checked((nuint)/*Error near IL_0001: Stack underflow*/))
			{
				/*Error: Invalid branch target*/;
			}
			return (FDP)(ulong)/*Error near IL_0007: Stack underflow*/;
		}
	}

	public unsafe FDP opposeCritRate
	{
		get
		{
			//IL_0003: Expected Obj, but got I4
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			((object[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = *(sbyte*)checked((nuint)/*Error near IL_0001: Stack underflow*/);
			if (checked(/*Error near IL_0004: Stack underflow*/ * /*Error near IL_0004: Stack underflow*/) == 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0005: Read out of bounds.*/;
		}
	}

	public FDP critPower
	{
		get
		{
			//IL_0001: Invalid comparison between Unknown and I
			if ((nint)/*Error near IL_0006: Stack underflow*/ != (nint)checked((nuint)/*Error near IL_0001: Stack underflow*/))
			{
				/*Error: Invalid branch target*/;
			}
			return (FDP)(ulong)/*Error near IL_0007: Stack underflow*/;
		}
	}

	public FDP defPenetrate
	{
		get
		{
			_ = (sbyte)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xEA*/;
		}
	}

	public FDP defIgnore
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			_ = /*Error near IL_0001: Stack underflow*/| /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xEA*/;
		}
	}

	public FP originWeight
	{
		get
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Invalid calli metadata token*/;
		}
	}

	public FP weight
	{
		get
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Invalid calli metadata token*/;
		}
	}

	public unsafe FDP suppressRatio
	{
		get
		{
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xEA*/;
		}
	}

	public FDP normalSuppressRatio
	{
		get
		{
			if (/*Error near IL_0002: Stack underflow*/ < /*Error near IL_0002: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xC7*/;
		}
	}

	public FDP skillSuppressRatio
	{
		get
		{
			if (/*Error near IL_0002: Stack underflow*/ > /*Error near IL_0002: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xC7*/;
		}
	}

	public FDP ultraSuppressRatio
	{
		get
		{
			if (/*Error near IL_0002: Stack underflow*/ <= /*Error near IL_0002: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xC7*/;
		}
	}

	public FDP markSuppressRatio
	{
		get
		{
			if (/*Error near IL_0002: Stack underflow*/ < /*Error near IL_0002: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xC7*/;
		}
	}

	public FDP summonSuppressRatio
	{
		get
		{
			if (/*Error near IL_0002: Stack underflow*/ != /*Error near IL_0002: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xC7*/;
		}
	}

	public FDP projectileSuppressRatio
	{
		get
		{
			/*Error: stloc 2 (out-of-bounds)*/;
			/*Error near IL_0001: Unknown opcode: 0xEA*/;
		}
	}

	public FDP otherSuppressRatio
	{
		get
		{
			/*Error: stloc 3 (out-of-bounds)*/;
			/*Error near IL_0001: Unknown opcode: 0xEA*/;
		}
	}

	public unsafe FDP normalDmgRatio
	{
		get
		{
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xEA*/;
		}
	}

	public unsafe FDP skillDmgRatio
	{
		get
		{
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xEA*/;
		}
	}

	public unsafe FDP ultraDmgRatio
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.Read<object>((void*)(nint)/*Error near IL_0001: Stack underflow*/);
			/*Error near IL_0001: Unknown opcode: 0xEA*/;
		}
	}

	public unsafe FDP otherDmgRatio
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0001: Stack underflow*/, /*Error near IL_0001: Stack underflow*/);
			/*Error near IL_0001: Unknown opcode: 0xEA*/;
		}
	}

	public unsafe FDP normalDmgRcdRatio
	{
		get
		{
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xEA*/;
		}
	}

	public unsafe FDP skillDmgRcdRatio
	{
		get
		{
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xEA*/;
		}
	}

	public FDP ultraDmgRcdRatio
	{
		get
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ == 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xC7*/;
		}
	}

	public FDP otherDmgRcdRatio
	{
		get
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xC7*/;
		}
	}

	public FDP markDmgRatio
	{
		get
		{
			if (/*Error near IL_0002: Stack underflow*/ == /*Error near IL_0002: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xC7*/;
		}
	}

	public FDP markDmgRcdRatio
	{
		get
		{
			if (/*Error near IL_0002: Stack underflow*/ >= /*Error near IL_0002: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xC7*/;
		}
	}

	public FDP summonDmgRatio
	{
		get
		{
			/*Error: Invalid metadata token*/;
		}
	}

	public FDP summonDmgRcdRatio
	{
		get
		{
			/*Error: Invalid metadata token*/;
		}
	}

	public FDP projectileDmgRatio
	{
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public FDP projectileDmgRcdRatio
	{
		get
		{
			/*Error: Invalid branch target*/;
		}
	}

	public HotfixEnum.characterJobClass jobClass
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

	public HotfixEnum.characterAttackType attackType
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

	public HotfixEnum.characterSearchTargetType searchType
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

	public string actorName
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

	public HotfixEnum.actorMovType originMoveType
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

	public HotfixEnum.actorMovType moveType
	{
		get
		{
			/*Error: Invalid field token*/;
		}
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public HotfixEnum.FrozenTimeHighlightUnit assistWitchTimeTargetType
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

	public FP originRunSpeed
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

	public FP runSpeed
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected I4, but got Unknown
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
			}
		}
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public FP originWalkSpeed
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

	public FP walkSpeed
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected I4, but got Unknown
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
			}
		}
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public FP walktoRunDuration
	{
		get
		{
			/*Error: Invalid field token*/;
		}
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public FP moveAcceleration
	{
		get
		{
			/*Error: Invalid field token*/;
		}
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public FP moveDeceleration
	{
		get
		{
			/*Error: Invalid field token*/;
		}
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public FP moveRotationSpeed
	{
		get
		{
			/*Error: Invalid field token*/;
		}
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public FP skillRotationSpeed
	{
		get
		{
			/*Error: Invalid field token*/;
		}
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public FP originAttackSpeed
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

	public FP attackSpeed
	{
		get
		{
			/*Error: Invalid field token*/;
		}
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public FP attackCooldownTime
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected I4, but got Unknown
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
	}

	public FP shootDeviation
	{
		get
		{
			/*Error: Invalid field token*/;
		}
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public int originFactionID
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

	public int factionID
	{
		get
		{
			/*Error: Invalid field token*/;
		}
		set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public unsafe FP normalAttackSpd
	{
		get
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			if (/*Error near IL_0004: Stack underflow*/ >= /*Error near IL_0004: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = *(double*)(nint)/*Error near IL_0005: Stack underflow*/;
			/*Error near IL_0006: Invalid metadata token*/;
		}
	}

	public FDP originMoveSpeedRatio
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Expected I4, but got Unknown
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
			}
		}
		set
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected I4, but got Unknown
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
			}
		}
	}

	public FDP moveSpeedRatioAbsAmend
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
		set
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected I4, but got Unknown
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
			}
		}
	}

	public FDP moveSpeedRatio
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			_ = /*Error near IL_0001: Stack underflow*// /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xEA*/;
		}
	}

	public FDP genDmgRatio
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			_ = /*Error near IL_0001: Stack underflow*/& /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xEA*/;
		}
	}

	public FDP dmgPlus
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xEA*/;
		}
	}

	public FDP finalDmgRatio
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			_ = /*Error near IL_0001: Stack underflow*/- /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xEA*/;
		}
	}

	public FDP finalDmgPlus
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xEA*/;
		}
	}

	public FDP genDmgRcdRatio
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			_ = /*Error near IL_0001: Stack underflow*// /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xEA*/;
		}
	}

	public unsafe FDP dmgPlusRcd
	{
		get
		{
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xEA*/;
		}
	}

	public FDP toughnessDamageRatio
	{
		get
		{
			if (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0006: Unknown opcode: 0xF7*/;
		}
	}

	public FDP intensityRatio
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			_ = /*Error near IL_0001: Stack underflow*/% /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xEA*/;
		}
	}

	public FDP toughnessBrokenDmgRatio
	{
		get
		{
			if (/*Error near IL_0002: Stack underflow*/ >= /*Error near IL_0002: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xC7*/;
		}
	}

	public FDP addShieldStrengthenRatio
	{
		get
		{
			if (/*Error near IL_0002: Stack underflow*/ > /*Error near IL_0002: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xC7*/;
		}
	}

	public FDP beAddShieldStrengthenRatio
	{
		get
		{
			if (/*Error near IL_0002: Stack underflow*/ <= /*Error near IL_0002: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xC7*/;
		}
	}

	public FDP envAmendRatio
	{
		get
		{
			/*Error: ldarg 234 (out-of-bounds)*/;
			/*Error near IL_0002: Unknown opcode: 0xC7*/;
		}
	}

	public void ChangeAttributeValueWithElementOrDamageType(int key, FDP value)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected I4, but got Unknown
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
		}
	}

	public void AssignAttributeValueWithElementOrDamageType(int key, FDP value, bool isAssign)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected I4, but got Unknown
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
		}
	}

	public FDP GetAttributeValueWithElementOrDamageType(HotfixEnum.effectAttributeType type, HotfixEnum.elementType elementType, HotfixEnum.damageType damageType)
	{
		/*Error: Unknown opcode: 0xE7*/;
	}

	protected unsafe override void OnInit()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected F8, but got I
		if (/*Error near IL_0006: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		*(double*)(nint)/*Error near IL_0008: Stack underflow*/ = (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/);
		/*Error near IL_000a: Unknown opcode: 0xAF*/;
	}

	public void Reset()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = /*Error near IL_0008: Stack underflow*/+ (ulong)/*Error near IL_0007: Stack underflow*/;
			/*Error near IL_000a: Unknown opcode: 0xAF*/;
		}
	}

	protected override void OnShutdown()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected I4, but got Unknown
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

	private void OnValueChanged(HotfixEnum.effectAttributeType attributeType, HotfixEnum.parameterType parameterType, FDP old, FDP diff)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			throw (sbyte)18859880519342585L;
		}
	}

	private FDP GetAttributeValue(HotfixEnum.effectAttributeType type)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected I4, but got Unknown
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
		}
	}

	private FDP GetAttributeOriginValue(HotfixEnum.effectAttributeType type)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected I4, but got Unknown
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
		}
	}

	private void SetOriginIntValue(HotfixEnum.effectAttributeType type, int val, FDP ratio)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected I4, but got Unknown
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
		}
	}

	private void SetOriginIntValueAdjust(HotfixEnum.effectAttributeType type, int val, FDP ratio, int adjustRatio, int adjustFix)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected I4, but got Unknown
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
		}
	}

	private void SetOriginIntFloatValue(HotfixEnum.effectAttributeType type, int val, FDP ratio)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected I4, but got Unknown
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
		}
	}

	public void SetOriginAttributeData(Attribute attributeConfig, FDP ratio)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid calli metadata token*/;
		}
	}

	public void SetOriginAttributeData(Monster attributeConfig, FDP ratio)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/+ 576461832580202996L;
		}
		_ = (sbyte)checked((nuint)(-1));
		/*Error near IL_000e: Unknown opcode: 0xE3*/;
	}

	public void SetOriginAttributeData(MonsterValueTemplete attributeConfig, MonsterValueTempleteAdjust templeteAdjustInfo, FDP ratio)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldloca 231 (out-of-bounds)*/;
			/*OpCode not supported: DebugBreak*/;
			/*Error near IL_0004: Unknown opcode: 0xFB*/;
		}
	}

	public void SetOriginAttributeData(Character attributeConfig, FDP ratio)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/+ 576461579579785716L;
		}
		_ = (sbyte)checked((nuint)(-1));
		/*Error near IL_000e: Unknown opcode: 0xE3*/;
	}

	public void SetOriginAttributeData(Lua2CSharpInfo_CharAttribute attributeConfig, FDP ratio)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid calli metadata token*/;
		}
	}

	public ActorInfo()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid calli metadata token*/;
		}
	}
}
