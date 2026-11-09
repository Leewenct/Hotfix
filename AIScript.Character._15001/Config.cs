using System.Collections.Generic;
using TrueSync;

namespace AIScript.Character._15001;

public class Config
{
	public static readonly int damageTag_TriggerLightMark;

	public static readonly int damageTag_RateTriggerLightMark;

	public const int parameterId_RateTriggerLightMark = 0;

	public const string areaEffectKey_LightMark = "AreaEffect_150_LightTag_Boom";

	public const string tipsKey_TriggerLightMark = "LightMark_Trigger_Effect_02";

	public static readonly List<string> comboTagList_NormalAttack;

	public static readonly FP delay_ResetNormalAttackStage;

	public static readonly ComboInputBuffer.ActionKey[] comboKeys_Dodge;

	public static readonly FP duration_Dodge;

	public static readonly FP distance_Dodge;

	public static readonly int transitionRushSkillId;

	public static readonly ComboInputBuffer.ActionKey[] comboKeys_Rush;

	public static readonly ComboInputBuffer.ActionKey[] comboKeys_Rush_Independent;

	public static readonly ComboInputBuffer.ActionKey[] comboKeys_SpecialRushEnd;

	public const bool useSpecialRushEnd = false;

	public static readonly FP interruptTime_Rush;

	public const string comboTag_UltraSkill_Timeline = "150_Ultra_TL";

	public const string comboTag_UltraSkill_NoTimeline = "150_Ultra_NoTL";

	public const string eventName_UltraSkill_Attack = "150_Ultra_Attack";

	public const string areaEffectKey_UltraSkill = "AreaEffect_150_Ultra";

	public static readonly FP offset_AreaEffect_UltraSkill;

	public const int perkId_41 = 515041;

	public const string areaEffectKey_P41 = "AreaEffect_150_Ultra_P41";

	public const int perkId_42 = 515042;

	public static readonly int damageTag_Trigger_P42;

	public const int parameterId_P42_1 = 15042011;

	public const int parameterId_P42_2 = 15042012;

	public const int additionalAttrId_P42 = 15042001;

	public const int perkId_43 = 515043;

	public static readonly int damageTag_Trigger_P43;

	public const int buffId_P43 = 15043011;

	public const int buffId_D1 = 15096111;

	public const int buffId_D2 = 15096211;

	public const int buffId_D3 = 15096311;

	public const int buffId_D4 = 15096411;

	public const int additionalAttrId_D5 = 15096511;

	public const string logicTag_NormalAttackStage = "NormalAttackStage";

	unsafe static Config()
	{
		_ = *(double*)(int)(*(byte*)(nint)/*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xC1*/;
	}
}
