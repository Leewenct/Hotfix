using System.Runtime.CompilerServices;
using AdventureBehaviour;
using TrueSync;

namespace AIScript.Character._13201;

public class SkillScript_Ultra : SkillAdvancedBase
{
	private const string actionTag_Timeline = "132_Ultra_TL";

	private const string actionTag_NoTimeline = "132_Ultra_NoTL";

	private const string eventName_GenerateAreaEffect = "StartArea";

	private const string fxKey_Default = "fx_13201_base_Ultra_AOE";

	private const string areaEffectKey_Default = "AreaEffect_132_Ultra";

	private static readonly FP forwardOffset_NoTarget;

	private const string eventName_StopLookAt = "StopLock";

	private const int perkId_42 = 513242;

	private const string areaEffectKet_P42 = "AreaEffect_132_Ultra_P42";

	private const int perkId_43 = 513243;

	private const string actionTag_Timeline_P43 = "132_Ultra_TL";

	private const string actionTag_NoTimeline_P43 = "132_Ultra_NoTL";

	private const string fxKey_P43 = "fx_13201_base_Ultra_AOE_H6";

	private const string areaEffectKey_P43 = "AreaEffect_132_Ultra_H6";

	private PlayTimeline _playTimeline;

	private PlayFX _playFX;

	private bool _canLookAt;

	protected override void OnSkillEnable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		((short[])/*Error near IL_0003: Stack underflow*/)[checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/)] = 0;
		_ = /*Error near IL_0004: Stack underflow*/+ /*Error near IL_0004: Stack underflow*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public void OnStart()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = ((sbyte[])/*Error near IL_0004: Stack underflow*/)[((double[])checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))[0]];
		/*Error near IL_0004: Unknown opcode: 0xED*/;
	}

	private unsafe void OnPlayTimelineFinish()
	{
		_ = *(byte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
	}

	private unsafe void OnNoPlayTimeLine()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0002: Stack underflow*/- *(byte*)(nint)/*Error near IL_0001: Stack underflow*/;
	}

	public void OnUpdate()
	{
		/*Error: Unknown opcode: 0xF0*/;
	}

	private void LookAt()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected I4, but got Unknown
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
		}
	}

	private unsafe void OnCustomEvent(string eventName)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		System.Runtime.CompilerServices.Unsafe.Read<object>((void*)(*(ulong*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)));
		/*Error near IL_0003: Unknown opcode: 0xAF*/;
	}

	private TSVector2 GetAreaEffectPosition()
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

	private void OnFinish()
	{
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	private void OnInterrupt()
	{
		/*Error: Read out of bounds.*/;
	}

	protected override void OnSkillDisable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		((sbyte[])/*Error near IL_0003: Stack underflow*/)[checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/)] = 0;
		_ = /*Error near IL_0004: Stack underflow*/+ /*Error near IL_0004: Stack underflow*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public SkillScript_Ultra()
	{
		/*Error: Invalid field token*/;
	}
}
