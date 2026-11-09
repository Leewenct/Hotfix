using System.Collections.Generic;
using TrueSync;

namespace AIScript.Character._14301;

public class Config
{
	public static readonly FP distance_SwitchAttackMode;

	public const string skillMoveFxKey_1 = "fx_14301_loop_foot_l";

	public const string skillMoveFxKey_2 = "fx_14301_loop_foot_r";

	public const string skillMoveFxKey_3 = "fx_14301_loop_foot_root";

	public const int buffId_m1 = 14396111;

	public const int buffId_m2 = 14396211;

	public const int buffId_m3 = 14396311;

	public const int buffId_m4 = 14396411;

	public const int onceId_m5 = 14396511;

	public static readonly int damageTag_TriggerWindMark;

	public const string areaEffectKey_WindMark = "AreaEffect_143_WindTagTrigger_QiXuan";

	public static readonly FP randomRadius_AreaEffect_WindMark;

	public const string tipsKey_TriggerWindMark = "WindMark_Trigger_Effect_04";

	public static readonly List<string> comboTagList_NormalAttack_Melee;

	public static readonly List<string> comboTagList_NormalAttack_Range;

	public static readonly FP delay_ResetNormalAttackStage;

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

	public const string comboTag_UltraSkill_Timeline = "Ultra_TimelineOn_T2";

	public const string comboTag_UltraSkill_NoTimeline = "Ultra_TimelineOff_T2";

	public const string eventName_UltraSkill_GenerateMainAreaEffect = "WindDomainOpen";

	public const string eventName_UltraSkill_StopMainAreaEffect = "WindDomainClose";

	public const string mainAreaEffectKey_UltraSkill = "AreaEffect_143_Ultra_WindDomain";

	public static readonly List<string> loopAttackFxKeyList_UltraSkill;

	public const string eventName_UltraSkill_LoopAttack_Low = "WindDomainQuickAtk_1";

	public static readonly FP fxSpeed_UltraSkill_LoopAttack_Low;

	public const string eventName_UltraSkill_LoopAttack_Middle = "WindDomainQuickAtk_2";

	public static readonly FP fxSpeed_UltraSkill_LoopAttack_Middle;

	public const string eventName_UltraSkill_LoopAttack_High = "WindDomainQuickAtk_3";

	public static readonly FP fxSpeed_UltraSkill_LoopAttack_High;

	public const string areaEffectKey_UltraSkill_LoopAttack = "AreaEffect_143_Ultra_WindDomainQuickAtk";

	public const int perkId_41 = 514341;

	public const string comboTag_UltraSkill_Timeline_P41 = "Ultra_TimelineOn_T2P41";

	public const string comboTag_UltraSkill_NoTimeline_P41 = "Ultra_TimelineOff_T2P41";

	public const int perkId_42 = 514342;

	public const int buffId_P42 = 14342011;

	public const int perkId_43 = 514343;

	public const string pullAreaEffectKey_P43 = "AreaEffect_143_Ultra_WindDomain_P43_XiYin";

	public const string logicTag_NormalAttackStage_Melee = "NormalAttackStage_Melee";

	public const string logicTag_NormalAttackStage_Range = "NormalAttackStage_Range";

	public const string logicTag_LastNormalAttackFinsihTime_Melee = "LastNormalAttackFinsihTime_Melee";

	public const string logicTag_LastNormalAttackFinsihTime_Range = "LastNormalAttackFinsihTime_Range";

	static Config()
	{
		/*Error: Unknown opcode: 0xF8*/;
	}
}
