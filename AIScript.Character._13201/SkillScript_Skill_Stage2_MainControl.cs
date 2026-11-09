using AdventureBehaviour;
using TrueSync;

namespace AIScript.Character._13201;

public class SkillScript_Skill_Stage2_MainControl : SkillScript_Skill_Base_MainControl
{
	private const string actionTag = "132_Main_Skill_S2";

	private static readonly FP speed_Dash;

	private static readonly FP maxDistance_Dash;

	private static readonly FP minDurationTime_Loop;

	private static readonly FP maxDurationTime_Loop;

	private const int buffId = 13293011;

	private const int perkId_2 = 513202;

	private const string actionTag_P2 = "132_Main_Skill_S2_P02";

	private const int perkId_4 = 513204;

	private static readonly FP useSkillInterval_P4;

	private static readonly int damageTag_P4;

	private const string areaEffectKey_P4 = "AreaEffect_132_Main_S2_P04_AOE";

	private Dash _dash;

	private bool _canHolding;

	private FP _loopDurationTime;

	private bool _canTriggerAOE;

	protected override void OnSkillEnable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = ((sbyte[])checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))[0uL];
		/*Error near IL_0004: Unknown opcode: 0xED*/;
	}

	private bool CanTriggerPerk_4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected I4, but got Unknown
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
		}
	}

	protected override void OnComboBegin()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xBD*/;
		}
	}

	protected override void OnAnticipationEnd()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xBE*/;
		}
	}

	public override void OnUpdate()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0xBF*/;
		}
	}

	protected override string GetActionTag()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 8;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	protected override void OnReceiveDamage(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((nint)/*Error near IL_0009: Stack underflow*/ <= (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/))
		{
			/*Error near IL_0009: Invalid metadata token*/;
		}
		/*Error near IL_0014: Unknown opcode: 0xEE*/;
	}

	protected override void OnSkillDisable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public SkillScript_Skill_Stage2_MainControl()
	{
		/*Error: Read out of bounds.*/;
	}

	static SkillScript_Skill_Stage2_MainControl()
	{
		/*Error: Unknown opcode: 0xF4*/;
	}
}
