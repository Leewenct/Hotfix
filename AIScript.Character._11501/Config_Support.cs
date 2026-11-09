using System.Collections.Generic;
using TrueSync;

namespace AIScript.Character._11501;

public class Config_Support
{
	public static readonly FP visionRange;

	public static readonly FP visionAttackRange;

	public static readonly FP visionDeg;

	public static readonly FP hearRange;

	public static readonly FP hearAttackRange;

	public static readonly List<string> comboTagList_NormalAttack;

	public const string comboTag_Skill = "Support_Blade_Enter";

	public const int replaceAnimationGroupIndex_Skill = 0;

	public const string eventName_TriggerFlyingBlade_Skill = "FlyBlade";

	public static readonly FP durationTime_TransformState;

	public const int buffId_TransformState = 11593211;

	public const int skillId_ExitTransformState = 11532002;

	public const string comboTag_ExitTransformState = "Support_Blade_Exit";

	public static readonly FP interval_CheckTrace;

	public static readonly FP distance_ForceTrace;

	public static readonly FP distance_StopTrace_ForPlayer;

	public static readonly FP randomRadius_Teleport;

	public const string triggerFxKey_FlyingBlade_First = "fx_11501_base_B2_Skill_Blade_Shoot_2";

	public const string triggerFxKey_FlyingBlade = "fx_11501_base_B2_Skill_Blade_Shoot_2";

	public static readonly FP shootDelay_FlyingBlade_First;

	public static readonly FP shootDelay_FlyingBlade;

	public const int shootCount_FlyingBlade = 6;

	public static readonly FP shootInterval_FlyingBlade;

	public static readonly List<TSVector2> shootAngleRange_FlyingBlade;

	public static readonly FP shootDistance_FlyingBlade;

	public static readonly FP shootPositionY_FlyingBlade;

	public const string bulletKey_FlyingBlade = "Bullet_11501_Support_Skill_Fly_Blade_Base";

	public static readonly FP triggerInterval_FlyingBlade;

	public const int perkId_21 = 511521;

	public const string triggerFxKey_FlyingBlade_First_P21 = "fx_11501_base_B2_Skill_Blade_Shoot_2_P21_Strengthen";

	public const string triggerFxKey_FlyingBlade_P21 = "fx_11501_base_B2_Skill_Blade_Shoot_2_P21_Strengthen";

	public const int shootCount_FlyingBlade_P21 = 10;

	public static readonly FP shootInterval_FlyingBlade_P21;

	public static readonly int damageTag_Trigger_P21;

	public const int buffId_P21 = 11521011;

	public const int additionalAttrId_P21 = 11521011;

	public const int perkId_22 = 511522;

	public const string triggerFxKey_FlyingBlade_First_P22 = "fx_11501_Base_B2_Skill_Blade_Shoot_2_P22_Strengthen";

	public const string triggerFxKey_FlyingBlade_First_P21_P22 = "fx_11501_base_B2_Skill_Blade_Shoot_2_P21P22_Strengthen";

	public const string triggerFxKey_FlyingBlade_P22 = "fx_11501_Base_B2_Skill_Blade_Shoot_2_P22_Strengthen";

	public const string triggerFxKey_FlyingBlade_P21_P22 = "fx_11501_base_B2_Skill_Blade_Shoot_2_P21P22_Strengthen";

	public const string bulletKey_FlyingBlade_P22 = "Bullet_11501_Support_Skill_Fly_Blade_P22_Strengthen";

	public static readonly int damageTag_Trigger_P22;

	public const string areaEffectKey_P22 = "AreaEffect_11501_Support_Skill_P22_Boom";

	public static readonly int damageTag_AddDamage_P22;

	public const int additionalAttrId_P22 = 11522011;

	public const int perkId_23 = 511523;

	public const string fxKey_Resident_P23 = "fx_11501_buff_B2_Skill_attack_P23_Strengthen";

	public static readonly List<string> comboTagList_NormalAttack_P23;

	public static readonly int damageTag_Trigger_P23;

	public const int additionalAttrId_P23 = 11523011;

	public const int perkId_24 = 511524;

	public const string eventName_NormalAttack_Hit_P24 = "115_SupportAttack";

	public const int triggerTimes_NormalAttack_Hit_P24 = 8;

	public const int skillId_P24 = 11532003;

	public const string comboTag_P24 = "Support_Blade_Skill";

	public const string comboTag_P23_P24 = "Support_Blade_StrengthenSkill";

	public const int perkId_25 = 511525;

	public static readonly int damageTag_Trigger_P25;

	public const int buffId_Count_1_P25 = 11525011;

	public const int buffId_ForSelf_1_P25 = 11525013;

	public const int additionalAttrId_1_P25 = 11525001;

	public const int buffId_Count_2_P25 = 11525014;

	public const int buffId_ForSelf_2_P25 = 11525015;

	public const int additionalAttrId_2_P25 = 11525002;

	public const int perkId_26 = 511526;

	public const string bulletKey_P26 = "Bullet_11501_Support_Skill_P26_Boom";

	public const string bulletKey_P22_P26 = "Bullet_11501_Support_Skill_P26P21_Boom_Strengthen";

	public const int parameterId_P26 = 11526011;

	public static readonly int damageTag_Trigger_P26;

	public static readonly int buffTag_Check_P26;

	public const int buffId_P26 = 11526011;

	public const int perkId_27 = 511527;

	public const string comboTag_ExitTransformState_P27 = "Support_Blade_Exit_P27";

	public const string comboTag_ExitTransformState_P21_P27 = "Support_Blade_Exit_P27P21";

	public static readonly int damageTag_Trigger_P27;

	public const int buffId_P27 = 11527011;

	public const int perkId_28 = 511528;

	public const int buffId_AddDamage_P28 = 11528011;

	public static readonly int damageTag_Trigger_P28;

	public const int additionalAttrId_P28 = 11528001;

	public const int parameterId_AddInterval_P28 = 11528011;

	public const int buffId_AddMoveSpeed_P28 = 11528012;

	public const int perkId_29 = 511529;

	public const int parameterId_TriggerDistance_P29 = 11529011;

	public const int buffId_ForTarget_P29 = 11529011;

	public const int buffId_ForSelf_P29 = 11529012;

	public const int perkId_30 = 511530;

	public static readonly int damageTag_Trigger_P30;

	public const string areaEffectKey_P30 = "AreaEffect_11501_Support_Skill_P30_Aoe";

	public const int parameterId_P30 = 11530011;

	public const int perkId_31 = 511531;

	public static readonly int damageTag_AddLightMark_P31;

	public const int shieldId_P31 = 11531001;

	public const int perkId_32 = 511532;

	public const int buffId_P32 = 11532011;

	public const int perkId_33 = 511533;

	public const int buffId_Resident_P33 = 11533011;

	public const int buffId_InBattle_P33 = 11533012;

	public static readonly FP removeTransfromStateBuffInterval;

	public static readonly int eventHashCode_TriggerFirstFlyingBlade;

	public const string localDataKey_HitTimes_P24 = "HitTimes_P24";

	static Config_Support()
	{
		/*Error: Unknown opcode: 0xF3*/;
	}
}
