using System.Collections.Generic;
using TrueSync;

namespace AIScript.Character._13401;

public class Config
{
	public const int ammoCountMax_Default = 3;

	public const int ammoCount_Default = 0;

	public static readonly int damageTag_TriggerFireMark;

	public static readonly int damageTag_FireMark;

	public const string tipsKey_TriggerFireMark = "FireMark_Trigger_Effect_02";

	public const int hitDamageId_FireMark = 134000001;

	public static readonly FP hitRadius_FireMark;

	public const string hitFxPath_FireMark = "fx_common_base_FireTag_Trigger_2";

	public const string hittedFxPath_FireMark = "";

	public static readonly FP stiffDuration_FireMark;

	public static readonly FP hitStrenth_FireMark;

	public static readonly List<string> comboTagList_NormalAttack_Default;

	public static readonly List<string> comboTagList_NormalAttack_Strength;

	public static readonly FP delay_ResetNormalAttackStage;

	public const string eventName_NormalAttackComplete = "Attack_End";

	public const string eventName_StrengthNormalAttackConsumeAmmo = "Use_Bullet";

	public const int consumeAmmoCount_StrengthNormalAttack = 1;

	public static readonly int damageTag_NormalAttack;

	public static readonly int damageTag_StrengthNormalAttack;

	public static readonly int damageTag_TriggerFanHit_NormalAttack;

	public const string areaEffect_FanHit_NormalAttack = "AreaEffect_13401_Attack_Sector";

	public static readonly ComboInputBuffer.ActionKey[] comboKeys_Dodge;

	public static readonly FP duration_Dodge;

	public static readonly FP distance_Dodge;

	public static readonly int transitionRushSkillId;

	public static readonly ComboInputBuffer.ActionKey[] comboKeys_Rush;

	public static readonly ComboInputBuffer.ActionKey[] comboKeys_Rush_Independent;

	public static readonly ComboInputBuffer.ActionKey[] comboKeys_SpecialRushEnd;

	public const bool useSpecialRushEnd = false;

	public static readonly FP interruptTime_Rush;

	public const string comboTag_UltraSkill_Timeline = "134_Ultra_TL";

	public const string comboTag_UltraSkill_NoTimeline = "134_Ultra_NoTL";

	public const string eventName_LookAtTarget_UltraSkill = "134_Ultra_Target";

	public static readonly int damageTag_UltraSkill;

	public const int attackLoopRound_UltraSkill = 2;

	public const string eventName_TurnAndDash_UltraSkill = "134_Ultra_Hurt";

	public static readonly FP dashSpeed_UltraSkill;

	public static readonly FP minDashDistance_UltraSkill;

	public static readonly FP maxDashDistance_UltraSkill;

	public static readonly FP addSearchTargetRange_UltraSkill;

	public static readonly FP changeSearchTargetDeg_UltraSkill;

	public const int perkId_41 = 513441;

	public const int buffId_P41 = 13441011;

	public const int perkId_42 = 513442;

	public const int addAttackLoopRound_P42 = 2;

	public const int additionalAttrId_P42 = 13442001;

	public const int perkId_43 = 513443;

	public const string eventName_StartLogic_P43 = "134_P43_Buff";

	public const int buffId_P43 = 13443011;

	public const int maxBuffCount_P43 = 6;

	public const int minBuffCount_P43 = 0;

	public static readonly FP removeBuffInterval_P43;

	public const int buffId_D1 = 13496111;

	public const int buffId_D2 = 13496211;

	public const int buffId_D3 = 13496311;

	public const int buffId_D4 = 13496411;

	public const int additionalAttrId_D5 = 13496511;

	public const string logicTag_NormalAttackStage = "NormalAttackStage";

	public const string logicTag_StrengthNormalAttackStage = "StrengthNormalAttackStage";

	public const string logicTag_ImproveNormalAttackDamage = "ImproveNormalAttackDamage";

	unsafe static Config()
	{
		_ = *(byte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xB1*/;
	}
}
