using System.Collections.Generic;
using TrueSync;

namespace AIScript.Character._11501;

public class Config_MainControl
{
	public const string comboTag_Skill = "Main_Cannon_Enter";

	public const int replaceAnimationGroupIndex_Skill = 1;

	public static readonly FP durationTime_TransformState;

	public const int skillId_NormalAttack_TransformState = 11511000;

	public static readonly Dictionary<int, FP> normalAttackCDDic_TransformState;

	public static readonly FP dodge_Duration_TransformState;

	public static readonly FP dodge_Distance_TransformState;

	public static readonly FP dodge_Duration_Special_TransformState;

	public static readonly FP dodge_Distance_Special_TransformState;

	public const string dodgeFx_TransformState = "fx_11501_base_Dodge_B1B2_Tail";

	public const int skillId_Rush_TransformState = 11571000;

	public static readonly ComboInputBuffer.ActionKey[] actionKeys_Rush_TransformState;

	public static readonly ComboInputBuffer.ActionKey[] actionKeys_Rush_Independent_TransformState;

	public static readonly ComboInputBuffer.ActionKey[] actionKeys_SpecialRushEnd_TransformState;

	public const bool useSpecialRushEnd_TransformState = false;

	public static readonly FP interruptTime_TransformState;

	public const int skillId_ExitTransformState = 11531002;

	public const string comboTag_Idle_ExitTransformState = "Main_Cannon_IdleExit";

	public const string comboTag_Aim_ExitTransformState = "Main_Cannon_Exit";

	public const int perkId_1 = 511501;

	public const int skillId_NormalAttack_TransformState_P1 = 11511010;

	public const int perkId_2 = 511502;

	public static readonly int damageTag_P2;

	public const int buffId_P2 = 11502011;

	public const int triggerBuffCount_P2 = 12;

	public const int buffId_Fx_P2 = 11502012;

	public const int additionalAttrId_P2 = 11502011;

	public const int perkId_3 = 511503;

	public static readonly int damageTag_P3;

	public const int buffId_P3 = 11503011;

	public const string areaEffectKey_P3 = "AreaEffect_11501_Main_Skill_P06_Beam";

	public const int perkId_4 = 511504;

	public const int perkId_5 = 511505;

	public static readonly int damageTag_Trigger_P5;

	public const int buffId_P5 = 11505011;

	public const int perkId_6 = 511506;

	public const int skillId_P6 = 11511030;

	public static readonly FP triggerInterval_P6;

	public const int perkId_7 = 511507;

	public static readonly FP triggerRadius_P7;

	public const int additionalAttrId_P7 = 11507001;

	public const int perkId_8 = 511508;

	public const string comboTag_Skill_P8 = "Main_Cannon_P08_Start_Hurt";

	public const string eventName_ShootFinish_P8 = "115_P08_Finish";

	public const int perkId_9 = 511509;

	public static readonly int damageTag_P9;

	public static readonly FP triggerInterval_P9;

	public static readonly Dictionary<SlotType, string> fxKeyDic_P9;

	public const string laserFx_Single_P9 = "fx_11501_bullet_B1P02_Cannon_Shoot_Strengthen";

	public const string laserFx_Single_Refraction_P9 = "fx_11501_bullet_B1P02_Cannon_Shoot_Strengthen";

	public const int additionalAttrId_P9 = 11509001;

	public const int perkId_10 = 511510;

	public static readonly int damageTag_P10;

	public const int buffId_P10 = 11510011;

	public const int perkId_11 = 511511;

	public const int buffId_P11 = 11511011;

	public const int buffId_Trigger_P11 = 11511012;

	public const int perkId_12 = 511512;

	public static readonly int damageTag_TriggerLightMark_P12;

	public const int buffId_P12 = 11512011;

	public const int perkId_13 = 511513;

	public const string areaEffectPath_P13 = "AreaEffect_11501_LimitDodge_Stun";

	public const int parameterId_13 = 11513011;

	public static readonly Dictionary<SlotType, List<int>> hitDamageIdDic;

	public const int hitDamageId_SingleHit_Salvo = 115110302;

	public static readonly Dictionary<SlotType, int> damageTagDic_Funnel;

	public const string eventName_SingleShoot = "115_Main_Shoot";

	public const string eventName_IrradiationShoot = "115_Main_Sustain_Shoot";

	public const string eventName_SalvoShoot = "115_Main_Salvo_Shoot";

	public static readonly List<string> comboTagList_Single;

	public const string laserFx_Single = "fx_11501_bullet_B2_Attack_Cannon";

	public const string laserFx_Single_Strengthen = "fx_11501_bullet_B1P02_Cannon_Shoot_Strengthen";

	public const string laserFx_Single_Refraction = "fx_11501_bullet_B2_Attack_Cannon";

	public const string comboTag_Irradiation = "Main_Cannon_P01_Sustain";

	public const string laserFx_Irradiation = "fx_11501_bullet_B2_Attack_Cannon_Sustain";

	public const string laserFx_Irradiation_Strengthen = "fx_11501_bullet_B2_Attack_Cannon_Sustain_Strengthen";

	public const string laserFx_Irradiation_Refraction = "fx_11501_bullet_B2_Attack_Cannon_Refraction";

	public const string laserHitSound_Irradiation = "char_11501_laser_impact";

	public const string laserHitSound_Irradiation_Strengthen = "char_11501_laser_impact_strengthen";

	public static readonly FP hitInterval_Irradiation;

	public static readonly FP interruptDistance_Irradiation;

	public static readonly FP checkDistanceInterval_Irradiation;

	public const string stopLaserSoundEvent_Irradiation = "char_11501_skill_branch2_all_laser_stop";

	public const int laser_RefractionMaxCount = 4;

	public const int laser_RefractionRadius = 5;

	public static readonly FP refreshTime_IrradiationRefraction;

	public const string comboTag_Salvo = "Main_Cannon_P03_Salvo";

	public const string laserFx_Salvo = "fx_11501_bullet_B1P03_Cannon_Shoot";

	public static readonly FP hitDelay_Salvo;

	public const int hitCount_SingleHit_Salvo = 4;

	public const string hittedFx_SingleHit_Salvo = "fx_11501_hit_2";

	public const string areaEffectPath_Salvo = "AreaEffect_11501_Main_Skill_P03_SalvoBoom";

	public static readonly List<SlotType> allLaserSlotTypes;

	public static readonly int eventHashCode_Trigger_LaserStrengthen;

	public static readonly int eventHashCode_Irradiation_UpdateTarget;

	public static readonly int eventHashCode_AfterFunnelFireHit;

	public const string logicTag_TriggerPerk_P2 = "TriggerPerk_P2";

	public const string logicTag_TriggerPerk_P6 = "TriggerPerk_P6";

	static Config_MainControl()
	{
		/*Error: Unknown opcode: 0xF4*/;
	}
}
