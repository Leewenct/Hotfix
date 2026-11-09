using System.Collections.Generic;
using TrueSync;

namespace AIScript.Character._13901;

public class Config
{
	public static readonly Dictionary<int, int> hitDamageIdMapping;

	public static readonly int damageTag_TriggerWaterMark;

	public const int hitDamageId_WaterMark = 139000001;

	public const string hittedFx_WaterMark = "fx_common_base_WaterMark1_Trigger2_A";

	public const int buffId_Tide_WaterMark = 4031;

	public const string areaEffectKey_Tide_WaterMark = "AreaEffect_13901_WaterTrigger";

	public const string tipsKey_TriggerWarterMark = "WaterMark_Trigger_Effect_06";

	public static readonly List<string> comboTagList_NormalAttack;

	public const string eventName_EnableCloseBlock_NormalAttack = "139_Atk_CloseBlock";

	public const string eventName_DisableCloseBlock_NormalAttack = "139_Atk_EnableBlock";

	public static readonly FP holdTime_NormalAttackStage;

	public static readonly FP moveDuration_LastStage_NormalAttack;

	public static readonly FP extraMoveDistance_LastStage_NormalAttack;

	public static readonly FP maxMoveDistance_LastStage_NormalAttack;

	public static readonly ComboInputBuffer.ActionKey[] comboKeys_Dodge;

	public static readonly FP duration_Dodge;

	public static readonly FP distance_Dodge;

	public static readonly int transitionRushSkillId;

	public static readonly ComboInputBuffer.ActionKey[] comboKeys_Rush;

	public static readonly ComboInputBuffer.ActionKey[] comboKeys_Rush_Independent;

	public static readonly ComboInputBuffer.ActionKey[] comboKeys_SpecialRushEnd;

	public const bool useSpecialRushEnd = false;

	public static readonly FP interruptTime_Rush;

	public const int skillId_FirstStage_UltraSkill = 13940000;

	public const string comboTag_FirstStage_Timeline_UltraSkill = "139_Ultra_TL";

	public const string comboTag_FirstStage_NoTimeline_UltraSkill = "139_Ultra_NoTL";

	public const string eventName_FirstStage_GenerateAreaEffect_UltraSkill = "Event_139_Ultra1_Area";

	public const string areaEffectKey_FirstStage_UltraSkill = "AreaEffect_13901_Ultra1";

	public const string eventName_FirstStage_AddBuff_UltraSkill = "139_Ultra1_AddBuff";

	public const int buffId_FirstStage_UltraSkill = 13994011;

	public static readonly int buffTag_FirstStage_UltraSkill;

	public const int skillId_SecondStage_UltraSkill = 13940001;

	public const string comboTag_SecondStage_Start_UltraSkill = "139_Ultra2_Start";

	public const string comboTag_SecondStage_Attack_UltraSkill = "139_Ultra2_Atk";

	public const string eventName_SecondStage_AddBuff_UltraSkill = "139_Ultra2_AddBuff";

	public const string eventName_SecondStage_LookAtTarget_UltraSkill = "139_Ultra2_LookAtTarget";

	public const string eventName_SecondStage_Move_UltraSkill = "Event_139_Ultra2_Move";

	public static readonly FP distance_TargetOffset_SecondStage_UltraSkill;

	public static readonly FP duration_Move_SecondStage_UltraSkill;

	public static readonly FP canUseTime_SecondStage_UltraSkill;

	public static readonly FP realMoveDistance_Attack_SecondStage_UltraSkill;

	public static readonly FP crossAdditionDistance_Attack_SecondStage_UltraSkill;

	public static readonly FP crossKeepAwayNavmeshEdgeDistance_Attack_SecondStage_UltraSkill;

	public const int perkId_41 = 513941;

	public const int buffId_P41 = 13941011;

	public const int perkId_42 = 513942;

	public static readonly int damageTag_Trigger_P42;

	public const int additionalAttrId_P42 = 13942001;

	public static readonly int parameterId_P42;

	public const int perkId_43 = 513943;

	public static readonly int damageTag_Trigger_P43;

	public const int additionalAttrId_P43 = 13943001;

	public const string comboTag_SecondStage_Attack_UltraSkill_P43 = "139_Ultra2_Atk_P43";

	public const int additionalAttrId_CritRate_D1 = 13996111;

	public const int additionalAttrId_WEDamage_D1 = 13996121;

	public const int buffId_SkillDamage_D2 = 13996211;

	public const int buffId_MarkDamage_D2 = 13996221;

	public const int buffId_D3 = 13996311;

	public const int buffId_D4 = 13996411;

	public const int additionalAttrId_D5 = 13996511;

	public const string logicTag_NormalAttackStage = "NormalAttackStage";

	public const string logicTag_LastNormalAttackFinishTime = "LastNormalAttackFinishTime";

	public static readonly int eventHashCode_ChangeUltraSkillStage;

	unsafe static Config()
	{
		_ = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
	}
}
