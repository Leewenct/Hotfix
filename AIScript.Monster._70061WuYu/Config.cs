using System.Collections.Generic;
using TrueSync;

namespace AIScript.Monster._70061WuYu;

public class Config
{
	public const string CenterPoint = "CenterPoint";

	public const string BottlePlaceholder = "BigPerfumePosition";

	public static readonly FP AxisAngle;

	public const int PerfumeGuardBuffId = 700619100;

	public const int PerfumeValueBuffMax = 100;

	public static readonly FP Phase1Accumlate;

	public static readonly FP Phase2Accumlate;

	public static readonly FP Phase3Accumlate;

	public static readonly FP PerfumeDisableTime;

	public const string PerfumeDispelBullet = "Weapon_70061WuYu_PerfumeAttack_Player";

	public static readonly FP DispelStunTime;

	public static readonly string FxPerfumeDispel;

	public static readonly List<int> ClearMonsterWhenDispel;

	public static readonly FP DispelBulletShootHeight;

	public static readonly Dictionary<string, (string interactiveId, string actionId)> BottleLandingMap;

	public static readonly string[] PlayerLampHolders;

	public static readonly string[] BossLampHolders;

	public const string Fx_PlayerLampOn = "fx_70061WuYu_loop_scene_light_l";

	public const string Fx_BossLampOn = "fx_70061WuYu_loop_scene_light_r";

	public const string Fx_PerfumeBottleFlash = "fx_70061_base_perfume_gaoliang";

	public static readonly FP Fx_PerfumeBottleFlashHeight;

	public const string PerfumeBottleBullet = "Weapon_70061WuYu_PerfumeBullet_Player";

	public const string PerfumeBottleBullet_Boss = "Weapon_70061WuYu_PerfumeBullet_WuYu";

	public const string BossBottleLandingHolder = "Position_BossBottleLanding";

	public const string Fx_LandedBottle_Player = "fx_70061_loop_perfume";

	public const string Fx_LandedBottle_Boss = "fx_70061_loop_perfume_purple";

	public const string Fx_BossBottleClear = "fx_70061_base_perfume_purple";

	public const int ExplodeTeammateId = 1;

	public const int BigHeadTeammateId = 2;

	public const int BigHeadRangedTeammateId = 6;

	public const int WarlockTeammateId = 3;

	public const int WarlockRangedTeammateId = 5;

	public const int TerrorTeammateId = 4;

	public const int GiantGhostTeammateId = 7;

	public const int Skill_GhostLegion_BroomDash = 7006190;

	public const int Skill_EerieDoorway = 7006110;

	public const int Skill_StrangeCamera = 7006120;

	public const int Skill_ContractSummon = 7006130;

	public const int Skill_BroomBullet = 7006150;

	public const int Skill_MagicRing = 7006160;

	public const int Skill_BombPerfume = 7006170;

	public const int Skill_SweepCombo = 7006180;

	public const int Skill_TerrorSummon = 7006140;

	public const int Skill_GiantGhost = 7006191;

	public const int Skill_BroomDecoy = 7006192;

	public const int Skill_BroomRiding = 7006193;

	public const int Skill_DispelStun = 7006195;

	public const int Skill_Wander = 7006197;

	public const int Skill_Wait = 9999999;

	public static readonly FP BroomDecoyCd;

	public static readonly FP BroomDecoyDamageThresholdPercent;

	public static readonly FP BroomDecoyDamageWindow;

	public static readonly FP ExplodeHpPercent;

	public static readonly FP BigHeadPercent;

	public static readonly FP WarlockPercent;

	public const string Tag_LoyalServant = "LoyalServantTagId";

	public const string Tag_FastExplode = "FastExplodeTagId";

	public const string Tag_PerfumeBrew = "PerfumeBrewTagId";

	public static readonly FP Entry_Phase1Accumlate;

	public static readonly FP Entry_Phase2Accumlate;

	public static readonly FP Entry_Phase3Accumlate;

	public const string Tag_DoubleHorror = "DoubleHorrorTagId";

	public const string Tag_SummonBoost_BigHead = "SummonBoostBigHeadTagId";

	public const string Tag_SummonBoost_Warlock = "SummonBoostWarlockTagId";

	public const string Tag_Perk8 = "Perk8TagId";

	public const int Perk8_ShieldId = 709054081;

	public const int Perk8_DamageDebuffId = 709054080;

	public const string Tag_Perk9 = "Perk9TagId";

	public const int Perk9_BuffId = 709054090;

	public const string Tag_Perk35 = "Perk35TagId";

	public static readonly FP Perk35_ImmuneDeadDuration;

	public const int Perk35_DebuffId = 709054350;

	public static readonly Dictionary<int, int> SummonerSyncBuffMap;

	public const string PhaseTag = "Phase";

	public const string PerfumeValueTag = "PerfumeValue";

	public const string CanGetPerfumeValueTag = "CanGetPerfume";

	public const string LastSentBossPerfumeIntTag = "LastSentBossPerfumeInt";

	public const string LastSentPlayerPerfumeIntTag = "LastSentPlayerPerfumeInt";

	public const string DispelStunPendingTag = "DispelStunPending";

	public const string CastDecoyLogicTag = "CastDecoyLogicTag";

	public const string PerfumeBottleBulletTag_Boss = "Weapon_70061WuYu_Skill1_Bullet_Boss";

	public const string PerfumeBottleBulletTag_Player = "Weapon_70061WuYu_Skill1_Bullet_Player";

	public const string BossBottleClearEventName = "WuYu_BossBottleClear";

	public const string BossPerfumeFullTag = "BossPerfumeFullTag";

	public const string FullSkillPhaseTag = "FullSkillPhase";

	public const string CanUseBroomDodgeTag = "CanUseBroomDodge";

	public const string PerfumeHasAddedTag = "PerfumeHasAddedTag";

	static Config()
	{
		/*Error: Unknown opcode: 0xEB*/;
	}
}
