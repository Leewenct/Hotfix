using System.Collections.Generic;
using TrueSync;

namespace AIScript.Monster._31801FeiLong;

public class Config
{
	public const int teammateIndex_BaoLin = 1;

	public const string comboTag_BaoLin_Spawn = "Spawn";

	public const string fxKey_BaoLin_Active = "fx_m31802_base_active";

	public const string fxKey_EarlyWarning_BaoLin_Active = "fx_warning_circular_2";

	public static readonly FP fxScale_EarlyWarning_BaoLin_Active;

	public static readonly FP delayTime_BaoLin_Active;

	public const string comboTag_BaoLin_Death = "Die";

	public const string eventName_BaoLin_Explosion = "Boom";

	public const string areaEffectKey_BaoLin_Explosion = "Area_Boom";

	public static readonly int buffTag_Burst;

	public const string fxKey_Scene_Burst_Lv1 = "fx_storyactivity_18_loop_boss_a_change_1";

	public const string fxKey_Screen_Burst_Lv1 = "fx_storyactivity_18_screen_fx_1";

	public const string fxKey_Scene_Burst_Lv2 = "fx_storyactivity_18_loop_boss_a_change_2";

	public const string fxKey_Screen_Burst_Lv2 = "fx_storyactivity_18_screen_fx_2";

	public const string areaEffectKey_Burst = "Area_BaoYan_Meteor";

	public static readonly DeterministicShape generateAreaEffectShape_Burst;

	public const int generateCount_AreaEffect_Burst = 1;

	public static readonly FP generateInterval_AreaEffect_Burst;

	public const int generateCount_AreaEffect_Burst_CriticalityDischarge = 2;

	public static readonly FP generateInterval_AreaEffect_Burst_CriticalityDischarge;

	public const string comboTag_Spwan = "Spawn";

	public const string comboTag_Ground_Death = "Die_Ground";

	public const string comboTag_Fly_Death = "Die_Fly";

	public const int skillId_Bite = 3180101;

	public const string comboTag_Bite_Left = "Tearing_Left";

	public const string comboTag_Bite_Right = "Tearing_Right";

	public const string comboTag_Bite_Left_Burst = "Tearing_Left_BaoYan";

	public const string comboTag_Bite_Right_Burst = "Tearing_Right_BaoYan";

	public const string eventName_GenerateBaoLin_Bite = "BaoLin";

	public static readonly FP innerRadius_GenerateBaoLin_Bite;

	public static readonly FP outerRadius_GenerateBaoLin_Bite;

	public static readonly FP angle_GenerateBaoLin_Bite;

	public static readonly FP offsetAngle_GenerateBaoLin_Bite;

	public const int totalCount_GenerateBaoLin_Bite = 3;

	public static readonly FP interval_GenerateBaoLin_Bite;

	public const string comboTag_Bite_Strength_Left = "Tearing_2_Left";

	public const string comboTag_Bite_Strength_Right = "Tearing_2_Right";

	public const string comboTag_Bite_Strength_Left_Burst = "Tearing_2_Left_BaoYan";

	public const string comboTag_Bite_Strength_Right_Burst = "Tearing_2_Right_BaoYan";

	public const string eventName_Bite_Strength_BaoLin = "BaoLin_Ex";

	public static readonly FP innerRadius_GenerateBaoLin_Bite_Strength;

	public static readonly FP outerRadius_GenerateBaoLin_Bite_Strength;

	public static readonly FP angle_GenerateBaoLin_Bite_Strength;

	public static readonly FP offsetAngle_GenerateBaoLin_Bite_Strength;

	public const int totalCount_GenerateBaoLin_Bite_Strength = 3;

	public static readonly FP interval_GenerateBaoLin_Bite_Strength;

	public const int skillId_Claw = 3180102;

	public static readonly FP turnDuration_Claw;

	public static readonly FP turnSpeed_Claw;

	public const string comboTag_CostalJointHit_Claw = "WingStrike_1";

	public const string comboTag_CostalJointHit_Claw_Brust = "WingStrike_1_BaoYan";

	public const string eventName_BaoLin_Left_Claw = "BaoLin_Left";

	public static readonly FP radius_GenerateBaoLin_Left_Claw;

	public static readonly FP angle_GenerateBaoLin_Left_Claw;

	public static readonly FP offsetAngle_GenerateBaoLin_Left_Claw;

	public const int totalCount_GenerateBaoLin_Left_Claw = 5;

	public static readonly FP interval_GenerateBaoLin_Left_Claw;

	public const string eventName_BaoLin_Right_Claw = "BaoLin_Right";

	public static readonly FP radius_GenerateBaoLin_Right_Claw;

	public static readonly FP angle_GenerateBaoLin_Right_Claw;

	public static readonly FP offsetAngle_GenerateBaoLin_Right_Claw;

	public const int totalCount_GenerateBaoLin_Right_Claw = 5;

	public static readonly FP interval_GenerateBaoLin_Right_Claw;

	public const string comboTag_Smash_Claw = "WingStrike_2";

	public const string comboTag_Smash_Claw_Brust = "WingStrike_2_BaoYan";

	public const string eventName_BaoLin_Both_Claw = "BaoLin";

	public const int skillId_Tail = 3180103;

	public const string comboTag_Tail_Left = "TailStrike_Left";

	public const string comboTag_Tail_Left_Burst = "TailStrike_Plus_Left_BaoYan";

	public const string comboTag_Tail_Right = "TailStrike_Right";

	public const string comboTag_Tail_Right_Burst = "TailStrike_Plus_Right_BaoYan";

	public const string eventName_Tail_BaoLin = "BaoLin";

	public static readonly FP innerRadius_GenerateBaoLin_Tail;

	public static readonly FP outerRadius_GenerateBaoLin_Tail;

	public static readonly FP angle_GenerateBaoLin_Tail;

	public static readonly FP offsetAngle_GenerateBaoLin_Tail;

	public const int totalCount_GenerateBaoLin_Tail = 6;

	public static readonly FP interval_GenerateBaoLin_Tail;

	public const string comboTag_Tail_Strength_Left = "TailStrike_Plus_Left";

	public const string comboTag_Tail_Strength_Left_Burst = "TailStrike_Plus_Left_BaoYan";

	public const string comboTag_Tail_Strength_Right = "TailStrike_Plus_Right";

	public const string comboTag_Tail_Strength_Right_Burst = "TailStrike_Plus_Right_BaoYan";

	public const string eventName_Tail_Strength_BaoLin = "BaoLin_Ex";

	public static readonly FP innerRadius_GenerateBaoLin_Tail_Strength;

	public static readonly FP outerRadius_GenerateBaoLin_Tail_Strength;

	public static readonly FP angle_GenerateBaoLin_Tail_Strength;

	public static readonly FP offsetAngle_GenerateBaoLin_Tail_Strength;

	public const int totalCount_GenerateBaoLin_Tail_Strength = 9;

	public static readonly FP interval_GenerateBaoLin_Tail_Strength;

	public const int skillId_Push = 3180104;

	public static readonly FP rotateSpeed_Start_Push;

	public const string comboTag_Charge_Push = "Dash_Ready";

	public static readonly FP loopTime_Charge_Push;

	public const string comboTag_DashDrift_Push = "Dash_Mode1";

	public const string comboTag_Left_Drift_Push = "Dash_Mode1_Left";

	public const string comboTag_Right_Drift_Push = "Dash_Mode1_Right";

	public const string comboTag_DashDrift_Push_Burst = "Dash_Mode1_BaoYan";

	public const string comboTag_Left_Drift_Push_Burst = "Dash_Mode1_Left_BaoYan";

	public const string comboTag_Right_Drift_Push_Burst = "Dash_Mode1_Right_BaoYan";

	public const string comboTag_DashHit_Push = "Dash_Mode2";

	public const string comboTag_DashHit_Push_Burst = "Dash_Mode2_BaoYan";

	public static readonly FP dashSpeed_Push;

	public static readonly FP dashDistance_Push;

	public static readonly FP minDistance_Dash_Push;

	public static readonly FP maxDistance_Center_Dash_Strength_Push;

	public static readonly FP driftDashSpeed_Push;

	public static readonly FP driftDashDistance_Push;

	public static readonly FP driftRotateTime_Push;

	public static readonly FP limitTargetAngle_Drift_Push;

	public static readonly FP length_GenerateBaoLin_Dash_Push;

	public static readonly FP width_GenerateBaoLin_Dash_Push;

	public static readonly FP offset_GenerateBaoLin_Dash_Push;

	public const int count_GenerateBaoLin_Dash_Push = 1;

	public const int count_GenerateBaoLin_Dash_Strength_Push = 2;

	public static readonly FP interval_GenerateBaoLin_Dash_Push;

	public const string eventName_Push_Strength_BaoLin = "BaoLin";

	public static readonly FP innerRadius_GenerateBaoLin_Push_Strength;

	public static readonly FP outerRadius_GenerateBaoLin_Push_Strength;

	public static readonly FP angle_GenerateBaoLin_Push_Strength;

	public static readonly FP offsetAngle_GenerateBaoLin_Push_Strength;

	public const int totalCount_GenerateBaoLin_Push_Strength = 4;

	public static readonly FP interval_GenerateBaoLin_Push_Strength;

	public const int skillId_FireBreath = 3180111;

	public const string comboTag_FireBreath = "FanFire";

	public const string eventName_GenerateBaoLin_FireBreath = "BaoLin";

	public static readonly FP radius_GenerateBaoLin_FireBreath;

	public static readonly FP angle_GenerateBaoLin_FireBreath;

	public static readonly FP offset_GenerateBaoLin_FireBreath;

	public const int totalCount_GenerateBaoLin_FireBreath = 4;

	public static readonly FP interval_GenerateBaoLin_FireBreath;

	public static readonly FP loopTime_FireBreath;

	public static readonly FP rotateSpeed_FireBreath;

	public const string eventName_Attack_FireBreath = "BaoLin_Fire";

	public static readonly FP radius_Big_Attack_FireBreath;

	public static readonly FP angle_Big_Attack_FireBreath;

	public static readonly FP offset_Big_Attack_FireBreath;

	public static readonly FP radius_Small_Attack_FireBreath;

	public static readonly FP angle_Small_Attack_FireBreath;

	public static readonly FP offset_Small_Attack_FireBreath;

	public const int skillId_HeatDischarge = 3180112;

	public const string comboTag_HeatDischarge = "CircleFire";

	public const string eventName_GenerateBaoLin_HeatDischarge = "BaoLin";

	public static readonly FP radius_GenerateBaoLin_HeatDischarge;

	public const int totalCount_GenerateBaoLin_HeatDischarge = 8;

	public static readonly FP interval_GenerateBaoLin_HeatDischarge;

	public static readonly FP loopTime_HeatDischarge;

	public const string eventName_Attack_HeatDischarge = "BaoLin_Fire";

	public static readonly int radius_Attack_HeatDischarge;

	public const int skillId_FireBurst = 3180113;

	public const string comboTag_Ground_FireBurst = "Transform_Ground";

	public const string comboTag_Fly_FireBurst = "Transform_Fly";

	public static readonly int areaEffectTag_FireBurst;

	public const int skillId_Tired = 3180132;

	public const string comboTag_Tired = "Tired";

	public static readonly FP loopTime_Tired;

	public const int skillId_Fly = 3180131;

	public const string comboTag_Fly = "Fly_Start";

	public const int skillId_FireBall = 3180121;

	public const string comboTag_FireBall = "FireBall";

	public const int loopTimes_FireBall = 3;

	public static readonly FP limitAngle_FireBall;

	public const string eventName_Shoot_FireBall = "Fire";

	public const string linkFxKey_FireBall = "fx_m31801_bullet_Fly_Skill1_loop";

	public static readonly SlotType linkFxSourceSlot_FireBall;

	public static readonly FP linkFxDuration_FireBall;

	public const string areaEffectKey_FireBall = "Area_FlySkill1_FireBall";

	public const int skillId_Strike = 3180123;

	public const string comboTag_Left_Strike = "FlyDash_Left";

	public const string comboTag_Right_Strike = "FlyDash_Right";

	public static readonly List<TSVector2> targetPointList_Strike;

	public static readonly FP distance_FilterTargetPoint_Strike;

	public static readonly FP hopeDistance_FilterTargetPoint_Strike;

	public static readonly FP minAngle_FilterTargetPoint_Strike;

	public static readonly FP maxAngle_FilterTargetPoint_Strike;

	public static readonly FP rotateSpeed_First_Strike;

	public static readonly FP rotateSpeed_Second_Strike;

	public static readonly FP dashSpeed_Strike;

	public static readonly FP length_GenerateBaoLin_Dash_Strike;

	public static readonly FP width_GenerateBaoLin_Dash_Strike;

	public static readonly FP offset_GenerateBaoLin_Dash_Strike;

	public const int count_GenerateBaoLin_Dash_Strike = 2;

	public static readonly FP interval_GenerateBaoLin_Dash_Strike;

	public const int skillId_Bombing = 3180122;

	public const string comboTag_First_Bombing = "Bombing_Out";

	public const string eventName_First_GenerateBaoLin_Bombing = "BaoLin_Out";

	public static readonly FP innerRadius_First_GenerateBaoLin_Bombing;

	public static readonly FP outerRadius_First_GenerateBaoLin_Bombing;

	public const int totalCount_First_GenerateBaoLin_Bombing = 12;

	public static readonly FP interval_First_GenerateBaoLin_Bombing;

	public const string comboTag_Second_Bombing = "Bombing_In";

	public const string eventName_Second_GenerateBaoLin_Bombing = "BaoLin_In";

	public static readonly FP radius_Second_GenerateBaoLin_Bombing;

	public const int totalCount_Second_GenerateBaoLin_Bombing = 10;

	public static readonly FP interval_Second_GenerateBaoLin_Bombing;

	public const string comboTag_Third_Bombing = "Bombing_End";

	public const string eventName_Third_GenerateBaoLin_Bombing = "BaoLin_End";

	public static readonly FP length_Third_GenerateBaoLin_Bombing;

	public static readonly FP width_Third_GenerateBaoLin_Bombing;

	public static readonly FP offset_Third_GenerateBaoLin_Bombing;

	public const int totalCount_Third_GenerateBaoLin_Bombing = 8;

	public static readonly FP interval_Third_GenerateBaoLin_Bombing;

	public const int skillId_CriticalityDischarge = 3180124;

	public const string fxKey_EarlyWarning_CriticalityDischarge = "fx_warning_circular_10";

	public static readonly FP duration_EarlyWarning_CriticalityDischarge;

	public static readonly FP followTime_EarlyWarning_CriticalityDischarge;

	public const string comboTag_Ready_CriticalityDischarge = "Ultra_Ready";

	public static readonly FP loopTime_Ready_CriticalityDischarge;

	public const string eventName_Hide_CriticalityDischarge = "Hide";

	public const string comboTag_Dive_CriticalityDischarge = "Ultra_Attack";

	public const string eventName_GenerateBaoLin_CriticalityDischarge = "BaoLin";

	public static readonly FP radius_GenerateBaoLin_CriticalityDischarge;

	public const int totalCount_GenerateBaoLin_CriticalityDischarge = 12;

	public static readonly FP interval_GenerateBaoLin_CriticalityDischarge;

	public const int skillId_ToughnessBrokenByFly = 3180133;

	public const string comboTag_ToughnessBrokenByFly = "Idle";

	public const string eventName_Interrupt_ToughnessBrokenByFly = "End";

	public static readonly FP hpPercent_ChangeStage;

	public const int battleLevel_ChangeStage_BossRush = 15;

	public static readonly FP defautRate_TriggerTiredSkill;

	public static readonly FP reduceRate_TriggerTiredSkill;

	public static readonly FP filterDistance_FlySkill;

	public static readonly int tag_BaoLin;

	public static readonly int eventHashCode_BaoLin_Explosion;

	public const string logicTag_SkillStrength = "SkillStrength";

	public const string logicTag_CanTriggerBurst = "logicTag_CanTriggerBurst";

	public const string logicTag_FireBurst_Times = "FireBurst_Times";

	public const string logicTag_IsFlyState = "IsFlyState";

	static Config()
	{
		/*Error: Unknown opcode: 0xEC*/;
	}
}
