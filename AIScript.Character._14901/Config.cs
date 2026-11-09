using System.Collections.Generic;
using TrueSync;

namespace AIScript.Character._14901;

public class Config
{
	public static readonly int damageTag_UltraSkill;

	public static readonly int damageTag_NormalAtk;

	public static readonly int damageTag_Gray;

	public static readonly int triggerDamageTag_EarthMark;

	public const string tipsKey_TriggerMark = "LandMark_Trigger_Effect_02";

	public const string areaEffectKey_TriggerLandMark = "AreaEffect_149_LandTag1_Stone";

	public static readonly int damageTag_GraySkill;

	public const int buff_m1 = 14996111;

	public static readonly FP cd_ScriptParameter_m1;

	public const int buff_m2 = 14996211;

	public const int buff_m3 = 14996311;

	public const int buff_m4 = 14996411;

	public const int onceId_m5 = 14996511;

	public static readonly List<string> comboTagList_NormalAttack;

	public static List<string> dicNormalTag_plus;

	public static List<string> dicNormalTag_plus_p2;

	public static readonly FP holdTime_NormalAttackStage;

	public const string eventName_StopLockDirection_NormalAttack = "149_S";

	public static readonly ComboInputBuffer.ActionKey[] comboKeys_Dodge;

	public static readonly FP duration_Dodge;

	public static readonly FP distance_Dodge;

	public static readonly int transitionRushSkillId;

	public static readonly ComboInputBuffer.ActionKey[] comboKeys_Rush;

	public static readonly ComboInputBuffer.ActionKey[] comboKeys_Rush_Independent;

	public static readonly ComboInputBuffer.ActionKey[] comboKeys_SpecialRushEnd;

	public const bool useSpecialRushEnd = false;

	public static readonly FP interruptTime_Rush;

	public const string comboTag_UltraSkill_Timeline = "149_Ultra_TL";

	public const string comboTag_UltraSkill_NoTimeline = "149_Ultra_NoTL";

	public const int perkId_41 = 514941;

	public const string comboTag_UltraSkill_Timeline_41 = "149_Ultra_P41_TL";

	public const string comboTag_UltraSkill_NoTimeline_41 = "149_Ultra_P41_NoTL";

	public const int perkId_42 = 514942;

	public const int buffId_42 = 14942011;

	public const int onceId_42 = 14942001;

	public const int perkId_43 = 514943;

	public const int range_43 = 10;

	public const int onceId_43 = 14943001;

	public const int buff_tag_43 = 14943011;

	public const int buff_43 = 14943012;

	public static HotfixEnum.monsterEpicType monsterEventType;

	public const string logicTag_NormalAttackStage = "NormalAttackStage";

	unsafe static Config()
	{
		checked
		{
			_ = (long)(*unchecked((byte*)(nint)/*Error near IL_0001: Stack underflow*/));
			/*Error near IL_0002: Unknown opcode: 0xC5*/;
		}
	}
}
