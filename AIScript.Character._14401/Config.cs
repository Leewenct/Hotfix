using System.Collections.Generic;
using TrueSync;

namespace AIScript.Character._14401;

public class Config
{
	public static readonly Dictionary<int, int> hitDamageIdMapping;

	public static readonly int damageTag_TriggerWaterMark;

	public const string areaEffectKey_TriggerWaterMark = "AreaEffect_144_WaterTag1_Boom";

	public const string tipsKey_TriggerWarterMark = "WaterMark_Trigger_Effect_05";

	public const int buffId_Cold = 4021;

	public static readonly int buffTag_Cold;

	public const int maxCount_ColdBuff = 3;

	public const int buffId_Frozen = 4100;

	public const int monsterId_Summon = 14401111;

	public static readonly Dictionary<int, int> replaceMonsterIdDic_Summon_ForSkin;

	public const int skillId_Summon = 14410010;

	public static readonly FP delayDestoryTime_Summon;

	public static readonly SummonCfg summonCfg_Summon;

	public static readonly List<string> comboTagList_NormalAttack;

	public const string eventName_AddBuff_NormalAttack = "144_AtkInvincibleAdd";

	public const string eventName_RemoveBuff_NormalAttack = "144_AtkInvincibleRemove";

	public const string eventName_StopLockDirection_NormalAttack = "144_S";

	public const int buffId_NormalAttack = 14400001;

	public static readonly FP holdTime_NormalAttackStage;

	public static readonly ComboInputBuffer.ActionKey[] comboKeys_Dodge;

	public static readonly FP duration_Dodge;

	public static readonly FP distance_Dodge;

	public static readonly int transitionRushSkillId;

	public static readonly FP realDistance_Dodge;

	public static readonly FP crossAdditionDistance_Dodge;

	public static readonly FP crossKeepAwayNavmeshEdgeDistance_Dodge;

	public static readonly ComboInputBuffer.ActionKey[] comboKeys_Rush;

	public static readonly ComboInputBuffer.ActionKey[] comboKeys_Rush_Independent;

	public static readonly ComboInputBuffer.ActionKey[] comboKeys_SpecialRushEnd;

	public const bool useSpecialRushEnd = false;

	public static readonly FP interruptTime_Rush;

	public const string comboTag_UltraSkill_Timeline = "144_Ultra_TL";

	public const string comboTag_UltraSkill_NoTimeline = "144_Ultra_NoTL";

	public const string eventName_HideModel_UltraSkill = "144_UltraFXAdd";

	public const string eventName_ShowModel_UltraSkill = "144_UltraFXRemove";

	public const int perkId_41 = 514441;

	public static readonly int damageTag_Trigger_P41;

	public const int additionalAttrId_P41 = 14441001;

	public const int parameterId_P41 = 14441011;

	public const int perkId_42 = 514442;

	public const int buffId_P42 = 14442011;

	public const int perkId_43 = 514443;

	public static readonly int damageTag_Trigger_P43;

	public const int additionalAttrId_P43 = 14443001;

	public const int buffId_D1 = 14496111;

	public const int buffId_D2 = 14496211;

	public static readonly int damageTag_Trigger_D3;

	public const int buffId_D3 = 14496311;

	public const int buffId_D4 = 14496411;

	public const int additionalAttrId_D5 = 14496511;

	public const string logicTag_NormalAttackStage = "NormalAttackStage";

	public const string logicTag_SetDataFinish_Summon = "SummonFinish_Summon";

	public const string logicTag_SpawnFx_Summon = "SpawnFx_Summon";

	public const string logicTag_DelayUseSkillTime_Summon = "DelayUseSkillTime_Summon";

	public const string logicTag_SkillComboTag_Summon = "SkillComboTag_Summon";

	public const string logicTag_CloseBlock_Summon = "CloseBlock_Summon";

	public const string logicTag_OpenCrossObstacleMode_Summon = "OpenCrossObstacleMode_Summon";

	unsafe static Config()
	{
		_ = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
	}
}
