using TrueSync;

namespace AIScript.Character._11601;

public class Config
{
	public static readonly int damageTag_TriggerLandMark;

	public const string tipsKey_TriggerLandMark = "LandMark_Trigger_Effect_02";

	public const string areaEffectKey_LandMark = "AreaEffect_11601_LandTag1_Stone";

	public const string comboTag_NormalAttack = "Shoot";

	public const string eventName_Shoot_NormalAttack = "116_Event_NormalAtk_Shoot";

	public const string bulletKey_NormalAttack = "Bullet_11601_NormalBullet";

	public const int bulletCount_NormalAttack = 2;

	public static readonly FP shootIncludedAngle_NormalAttack;

	public static readonly TSVector shootPositionOffset_NormalAttack;

	public const string comboTag_NormalAttack_Special = "Melee";

	public static readonly FP distance_UseSpecialCombo_NormalAttack;

	public static readonly FP interval_UseSpecialCombo_NormalAttack;

	public static readonly ComboInputBuffer.ActionKey[] comboKeys_Dodge;

	public static readonly FP duration_Dodge;

	public static readonly FP distance_Dodge;

	public static readonly int transitionRushSkillId;

	public static readonly ComboInputBuffer.ActionKey[] comboKeys_Rush;

	public static readonly ComboInputBuffer.ActionKey[] comboKeys_Rush_Independent;

	public static readonly ComboInputBuffer.ActionKey[] comboKeys_SpecialRushEnd;

	public const bool useSpecialRushEnd = false;

	public static readonly FP interruptTime_Rush;

	public const string comboTag_UltraSkill_Timeline = "116_Ultra_TL";

	public const string comboTag_UltraSkill_NoTimeline = "116_Ultra_NoTL";

	public const string eventName_GenerateAreaEffect_UltraSkill = "116_Ultra_Area";

	public const string areaEffectKey_UltraSkill_Timeline = "AreaEffect_11601_Ultra_TL";

	public const string areaEffectKey_UltraSkill_NoTimeline = "AreaEffect_11601_Ultra";

	public const string eventName_BeginMove_UltraSkill = "116_UltraSkill_Movement";

	public static readonly FP maxMoveDistance_UltraSkill;

	public static readonly FP moveDuration_UltraSkill;

	public const string eventName_HideModel_UltraSkill = "HideModel";

	public const string eventName_ShowModel_UltraSkill = "ShowModel";

	public const int perkId_41 = 511641;

	public static readonly int damageTag_Trigger_P41;

	public const int additionalAttrId_P41 = 11641001;

	public const int perkId_42 = 511642;

	public static readonly int damageTag_Trigger_P42;

	public const int additionalAttrId_P42 = 11642001;

	public const int parameterId_P42 = 11642011;

	public const int perkId_43 = 511643;

	public const int buffId_P43 = 11643011;

	public static readonly int damageTag_Trigger_D1;

	public const int buffId_D1 = 11696111;

	public const int buffId_D2 = 11696211;

	public const int triggerTimes_D3 = 20;

	public const int buffId_D3 = 11696311;

	public const int additionalAttrId_D4 = 11696411;

	public static readonly int damageTag_Trigger_D5;

	public const int buffId_D5 = 11696511;

	public const string logicTag_LastUseSpecialCombo_NormalAttack = "LastUseSpecialCombo_NormalAttack";

	public const string logicTag_UltraSkillHitTimes = "UltraSkillHitTimes";

	unsafe static Config()
	{
		_ = *(byte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: ldarg 2 (out-of-bounds)*/;
		/*Error near IL_0002: Invalid metadata token*/;
	}
}
