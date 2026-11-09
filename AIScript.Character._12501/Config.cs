using System.Collections.Generic;
using TrueSync;

namespace AIScript.Character._12501;

public class Config
{
	public static readonly int tag_Cold;

	public static readonly int buffTag_Cold;

	public static readonly int buffTag_Frozen;

	public static readonly int damageTag_TriggerWaterCorrosion;

	public const string areaEffectKey_TriggerWaterCorrosion = "AreaEffect_125_WaterTag1_Boom";

	public const int maxCount_ColdBuff = 3;

	public const int buffId_Cold = 4021;

	public const int buffId_Frozen = 4100;

	public const string tipsKey_TriggerMark = "WaterMark_Trigger_Effect_05";

	public const int buffId_BerserkTiming = 12500002;

	public const int addTimingBuffCount_EnterBerserk = 20;

	public static readonly FP interval_ReduceTimingBuffCount;

	public const int buffId_Berserk = 12594001;

	public const int skillId_ExitBerserk = 12500002;

	public const string comboTag_ExitBerserk = "Rage_End";

	public static readonly List<string> comboTagList_Normal;

	public static readonly List<string> comboTagList_Berserk;

	public static readonly FP delay_ResetNormalAttackStage;

	public static readonly ComboInputBuffer.ActionKey[] comboKeys_Normal;

	public static readonly FP duration_Normal;

	public static readonly FP distance_Normal;

	public static readonly ComboInputBuffer.ActionKey[] comboKeys_Berserk_Attack;

	public static readonly FP angle_CanUseAttackDodge;

	public static readonly FP minDistance_CanUseAttackDodge;

	public static readonly FP maxDistance_CanUseAttackDodge;

	public static readonly FP duration_Berserk_Attack;

	public static readonly FP maxDistance_Berserk_Attack;

	public static readonly ComboInputBuffer.ActionKey[] comboKeys_Berserk_Slide;

	public static readonly FP duration_Berserk_Slide;

	public static readonly FP distance_Berserk_Slide;

	public static readonly int transitionRushSkillId;

	public static readonly ComboInputBuffer.ActionKey[] comboKeys_Rush;

	public static readonly ComboInputBuffer.ActionKey[] comboKeys_Rush_Independent;

	public static readonly ComboInputBuffer.ActionKey[] comboKeys_SpecialRushEnd;

	public const bool useSpecialRushEnd = false;

	public static readonly FP interruptTime;

	public const string comboTag_UltraSkill_Timeline = "Ultra_TL";

	public const string comboTag_UltraSkill_NoTimeline = "Ultra_NoTL";

	public const string eventName_UltraSkill_EnterBerserk = "StartRage";

	public static readonly int damageTag_UltraSkill_Pull;

	public const string eventName_UltraSkill_BeginPull = "Start_Catch";

	public const string linkFxKey_UltraSkill_Pull = "fx_12501_bullet_Ultra_TL2_tengman";

	public static readonly FP pullTime_UltraSkill;

	public static readonly FP pullSpeed_UltraSkill;

	public static readonly FP pullInterval_UltraSkill;

	public static readonly FP pullStrength_UltraSkill;

	public static readonly FP pullStopDistance_UltraSkill;

	public const int perkId_41 = 512541;

	public static readonly int damageTag_Trigger_P41;

	public const int buffId_P41 = 12541011;

	public const int additionalAttrId_Ultra_P41 = 12541002;

	public const int additionalAttrId_Berserk_P41 = 12541001;

	public const int perkId_42 = 512542;

	public const int buffId_P42 = 12542011;

	public const int perkId_43 = 512543;

	public static readonly int damageTag_TriggerA_P43;

	public const int buffId_A_P43 = 4100;

	public const int buffId_B_P43 = 12543011;

	public static readonly int damageTag_TriggerB_P43;

	public const int parameterId_P43 = 12543011;

	public const int additionalAttrId_P43 = 12543001;

	public static readonly int damageTag_Trigger_D1;

	public const int buffId_D1 = 12596111;

	public const int buffId_D2 = 12596211;

	public static readonly int damageTag_Trigger_D3;

	public const int buffId_D3 = 12596311;

	public const int buffId_D4 = 12596411;

	public const int additionalAttrId_D5 = 12596511;

	public static readonly int eventHashCode_EnterBerserk;

	unsafe static Config()
	{
		_ = *(byte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xE6*/;
	}
}
