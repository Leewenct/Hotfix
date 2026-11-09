using System.Collections.Generic;
using TrueSync;

namespace AIScript.Character._14401;

public class Config_MainControl
{
	public const int skillId_Normal = 14431000;

	public const string comboTag_Skill_Normal = "144_B1";

	public const int skillId_Strength = 14431001;

	public const string comboTag_Skill_Strength = "144_B1_Strength";

	public const int useNormalSkillTimes_SwitchSkill = 2;

	public static readonly FP realMoveDistance_Skill;

	public static readonly FP crossAdditionDistance_Skill;

	public static readonly FP crossKeepAwayNavmeshEdgeDistance_Skill;

	public const int buffId_Skill = 14493001;

	public const string eventName_AddBuff_Skill = "144_B1_InvincibleAdd";

	public const string eventName_RemoveBuff_Skill = "144_B1_InvincibleRemove";

	public const int buffId_Event_Skill = 14400001;

	public const int perkId_1 = 514401;

	public static readonly List<string> comboTagList_NormalAttack_P1;

	public const int buffId_P1 = 14401011;

	public const int perkId_2 = 514402;

	public static readonly List<TSVector2> summonOffset_P2;

	public const string eventName_Summon_P2 = "144_Shadow_Atk";

	public static readonly FP summonedDelayUseSkillTime_P2;

	public const int buffId_P2 = 14401011;

	public static readonly int damageTag_Trigger_P2;

	public const int additionalAttrId_P2 = 14402011;

	public const int perkId_3 = 514403;

	public const string comboTag_Skill_Strength_P3 = "144_B1P3_Strength";

	public const int useNormalSkillTimes_SwitchSkill_P3 = 1;

	public const int perkId_4 = 514404;

	public static readonly FP reduceSkillCD_P4;

	public static readonly FP summonedDelayUseSkillTime_P4;

	public static readonly int damageTag_Trigger_P4;

	public const int additionalAttrId_P4 = 14404011;

	public const int perkId_5 = 514405;

	public static readonly int damageTag_TriggerAddBuff_P5;

	public const int buffId_P5 = 14405011;

	public const int addBuffCount_P5 = 5;

	public static readonly FP triggerCD_AddBuff_P5;

	public static readonly int damageTag_TriggerAddDamage_P5;

	public const int additionalAttrId_P5 = 14405001;

	public const int perkId_6 = 514406;

	public static readonly int damageTag_TriggerAddBuff_P6;

	public const int buffId_NormalAttack_DamageAndSpeed_P6 = 14406011;

	public const int buffId_NormalAttack_LastStageDamage_P6 = 14406012;

	public const int parameterId_TriggerCD_P6 = 14406011;

	public static readonly int damageTag_TriggerAddDamage_P6;

	public static readonly int damageTag_TriggerAddDamage_P2_P6;

	public const int additionalAttrId_P6 = 14406001;

	public const int perkId_7 = 514407;

	public static readonly int damageTag_Trigger_P7;

	public static readonly List<string> areaEffectKeyList_P7;

	public const int parameterId_Rate_P7 = 14407011;

	public const int parameterId_CD_P7 = 14407012;

	public const int parameterId_Limit_P7 = 14407013;

	public const int perkId_8 = 514408;

	public const int buffId_P8 = 14408011;

	public static readonly int damageTag_Trigger_P8;

	public const int additionalAttrId_P8 = 14408001;

	public const int perkId_9 = 514409;

	public static readonly int damageTag_DamageTrigger_P9;

	public const int additionalAttrId_P9 = 14409001;

	public static readonly int damageTag_SkillTrigger_P9;

	public const int perkId_10 = 514410;

	public static readonly int damageTag_Trigger_P10;

	public const int additionalAttrId_P10 = 14410001;

	public const int perkId_11 = 514411;

	public const int buffId_P11 = 14411011;

	public const int perkId_12 = 514412;

	public const int buffId_P12 = 14412011;

	public const int perkId_13 = 514413;

	public const int buffId_P13 = 14413011;

	public const string logicTag_UseNormalSkillTimes = "UseNormalSkillTimes";

	public const string localDataKey_IsStrengthSkill = "IsStrengthSkill";

	public const string logicTag_TriggerPerk_P5 = "TriggerPerk_P5";

	public const string logicTag_AdditionalAttrCount_P2_P6 = "AdditionalAttrCount_P2_P6";

	static Config_MainControl()
	{
		/*Error: Unknown opcode: 0xF7*/;
	}
}
