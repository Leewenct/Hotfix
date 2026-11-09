using System.Collections.Generic;
using TrueSync;

namespace AIScript.Character._13401;

public class Config_MainControl
{
	public const string fxKey_HaveAmmo_Loop_1 = "fx_13401_loop_Main_Skill_Charging_handL";

	public const string fxKey_HaveAmmo_Loop_2 = "fx_13401_loop_Main_Skill_Charging_handR";

	public const int skillId = 13431000;

	public const string comboTag_Skill = "134_Main_Skill";

	public const int addAmmoCount_Skill = 3;

	public const string eventName_Skill_AddAmmo = "Add_Ammo_End";

	public static readonly int damageTag_Skill;

	public const int perkId_1 = 513401;

	public const string comboTag_Skill_P1 = "134_Main_Skill_P01";

	public const int ammoCountMax_P1 = 9;

	public const int addAmmoCount_Skill_P1 = 9;

	public const int perkId_2 = 513402;

	public static readonly List<string> comboTagList_NormalAttack_Strength_P2;

	public const int perkId_3 = 513403;

	public const int skillId_P3 = 13431000;

	public const int buffId_P3 = 13403011;

	public const int hitDamageId_P3 = 134503001;

	public const string hittedFxPath_P3 = "fx_13401_hit_Main_Skill_P03_Hurt";

	public static readonly FP stiffDuration_P3;

	public static readonly FP hitStrenth_P3;

	public const int perkId_4 = 513404;

	public static readonly List<string> comboTagList_NormalAttack_SpecialStrength_P4;

	public static readonly List<string> comboTagList_NormalAttack_SpecialStrength_P2_P4;

	public const int consumeAmmoCount_SpecialStrengthNormalAttack = 3;

	public const int buffId_P4 = 13404011;

	public const int perkId_5 = 513405;

	public static readonly int damageTag_TriggerFireMark_P5;

	public const int additionalAttrId_P5 = 13405001;

	public const int perkId_6 = 513406;

	public static readonly List<string> comboTagList_NormalAttack_Strength_P6;

	public static readonly List<string> comboTagList_NormalAttack_Strength_P2_P6;

	public static readonly List<string> comboTagList_NormalAttack_SpecialStrength_P4_P6;

	public static readonly List<string> comboTagList_NormalAttack_SpecialStrength_P2_P4_P6;

	public const int perkId_7 = 513407;

	public const int buffId_P7 = 13407011;

	public const int additionalAttrId_P7 = 13407001;

	public const int perkId_8 = 513408;

	public const int buffId_P8_1 = 13408011;

	public const int buffId_P8_2 = 13408012;

	public const int perkId_9 = 513409;

	public static readonly int damageTag_Trigger_P9;

	public static readonly List<int> buffIdList_P9;

	public const string areaEffectKey_P9 = "AreaEffect_13401_Main_Skill_P09_Boom";

	public static readonly FP hitDelay_P9;

	public const int perkId_10 = 513410;

	public const int buffId_P10 = 13410011;

	public static readonly FP addBuffInterval_P10;

	public const int additionalAttrId_P10 = 13410001;

	public const int perkId_11 = 513411;

	public const int buffId_P11 = 13411011;

	public const int perkId_12 = 513412;

	public const int buffId_P12 = 13412011;

	public const int perkId_13 = 513413;

	public const int parameterId_P13 = 13413011;

	public const int additionalAttrId_P13 = 13413001;

	public const string logicTag_SpecialStrengthNormalAttack = "SpecialStrengthNormalAttack";

	public const string logicTag_SpecialStrengthNormalAttackStage = "SpecialStrengthNormalAttackStage";

	unsafe static Config_MainControl()
	{
		_ = *(byte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xBF*/;
	}
}
