using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TrueSync;

namespace AIScript.Monster.TowerDefense._13701;

public static class Config
{
	public static readonly List<string> comboTagListNormalAttack;

	public const string CrossSlashTag = "Atk_Sp";

	public const string CrossSlashEnhanceTag = "Atk_Sp_P1";

	public static readonly FP SaveComboIndexTime;

	public const string NormalAttackCountName = "137TD_NormalAttackCount";

	public const string LastNormalAttackTimeName = "137TD_LastNormalAttackTime";

	public const int ArmedEnergyBuffId = 801370050;

	public const int ArmedEnergyGainPerAttack = 2;

	public const int CrossSlashCostEnergy = 10;

	public const int buffId_State_Skill = 801370040;

	public const int buffId_State_Skill_P04 = 801370060;

	public static readonly FP BaseSkillTime_Alert;

	public const string ComboTagSkillMain = "Skill_Main";

	public const string areaEffectKey_A_DiffuseAttack = "AreaEffect_137_MainSkill_Ring_OutAtk";

	public const string areaEffectKey_A_DiffuseAttack_Fast = "AreaEffect_137_MainSkill_Ring_OutAtk_P3";

	public const string areaEffectKey_A_DiffuseAttack_Big = "AreaEffect_137_MainSkill_Ring_OutAtk_P8";

	public const string areaEffectKey_A_DiffuseAttack_FastBig = "AreaEffect_137_MainSkill_Ring_OutAtk_P3P8";

	public const string areaEffectKey_B_ShrinkRotate = "AreaEffect_137_MainSkill_Ring_In";

	public const string areaEffectKey_B_ShrinkRotate_Fast = "AreaEffect_137_MainSkill_Ring_In_P3";

	public static readonly FP switchTime_Alert;

	public static readonly FP switchTime_Alert_Fast;

	public const int perkId_1 = 1370101;

	public const int perkId_2 = 1370102;

	public const int perkId_3 = 1370103;

	public const int perkId_4 = 1370104;

	public const string bulletAlias_Grenade = "Bullet_137_P2_ShouLei";

	public static readonly FP grenadeScatterRadius;

	public static readonly FP grenadeNoTargetDistance;

	public static readonly int grenadeBulletTag;

	public const string areaEffectKey_Grenade = "AreaEffect_137_P2_ShouLei_Bloom";

	public const int extraEnergyGain_P03 = 2;

	public static readonly FP addDuration_P04;

	public static bool IsInAlert(AdventureActor actor)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected I4, but got Unknown
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

	public static string SelectAlertSpreadKey(bool useFast, bool useBig)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		_ = (sbyte)checked((nuint)3u * unchecked((nuint)/*Error near IL_0008: ldloc 0 (out-of-bounds)*/));
		/*Error near IL_000c: Unknown opcode: 0xFF*/;
	}

	unsafe static Config()
	{
		//IL_0002: Expected Obj, but got I4
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)(*(short*)(nint)/*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0002: Unknown opcode: 0xCE*/;
	}
}
