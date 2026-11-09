using TrueSync;
using UnityEngine;

[CreateAssetMenu]
public class AdventureModuleConfigureData : ScriptableObject
{
	public TSVector2 Level_MaxSceneSize;

	public TSVector2 Level_MaxSceneSize_Min;

	public TSVector2 Level_SceneBlockSize;

	public TSVector2 Level_SceneCellSize;

	[Space]
	public int Level_MonsterPreloadCount;

	public int Level_EpicMonsterPreloadCount;

	public int Level_BossMonsterPreloadCount;

	public FP Level_RefRoomMonsterDelayTime;

	[Space]
	public FP Level_NavmeshUpdateInterval;

	public FP Level_NavigationMaxNearestNodeDistance;

	public FP Level_ReachableNearestNodeDistance;

	public FP Combat_HitboxDamageImmuneDuration;

	public FP Combat_HitboxContinuousDamageDetectInterval;

	public FP Combat_TrapImmuneDuration;

	[Space]
	public FP Combat_MaxAttackCooldownTime;

	[Space]
	public FP Skill_Locking_Time;

	[Space]
	public FP Combat_MaxJumpHeight;

	public FP Combat_MinJumpHeight;

	public FP Combat_MinJumpDuration;

	public FP Combat_Gravity;

	[Space]
	public FP PrefectDodge_BulletDistance;

	public FP PrefectDodge_MonsterDistance;

	public FP PrefectDodge_MeleeTime;

	[TSFPRange(0f, 1f)]
	public FP PrefectDodge_TimeScale;

	public FP PrefectDodge_TimeDuration;

	public FP PrefectDodge_TimeAfterDodgeBegin;

	public AdventurePlayerFeedbackEffectConfigureData FeedbackData_PrefectDodge;

	[Space]
	public FP dtRadius;

	[Space]
	public FP reloadDelayTime;

	[Space]
	public FP Actor_ReturnCDRate;

	[Space]
	public string BuffTag_ReduceAttr;

	public string BuffTag_Weaken;

	public string BuffTag_Enhance;

	public string BuffTag_ReduceMoveSpd;

	[Space]
	[TSFPRange(0f, 1f)]
	public FP FrozenTime_Scale;

	public Color WitchTime_BackgroundColor;

	public string FrozenTime_FXPath;

	[Space]
	public float skillUnExecutableTipDuration;

	public ActorRelatedResourceConfig CommonRelatedResourceConfig;

	public FP Actor_NavAgentAvoidRadiusRate;

	public FP Actor_NavigationMinUpdateIntervalTime;

	public FP Actor_DefaultNavigationAccelerationScaleFactor;

	public FP Actor_DefaultNavigationRotationSpeedScaleFactor;

	[Space]
	public FP Actor_WalkMovementSpeedScaleFactor;

	[Space]
	public bool Actor_Shake;

	public float Actor_Shake_SingleDuration;

	public float Actor_Shake_Range;

	public int Actor_Shake_LoopTimes;

	[Space]
	public FP Actor_Damage_HurtEffectAndAudio_CD;

	public string Actor_hit_effect;

	[Space]
	public string ToughnessBrokenFxPath;

	public int ToughnessBrokenState_BuffId;

	public string ToughnessBroken_IgnoreClearTag;

	public FP ToughnessBroken_RecoverTime;

	public FP ToughnessBroken_IdleDuration;

	public FP ToughnessProtectTime;

	[Space]
	public Color SearchRangeGizmoColor;

	public Color InputSearchRangeGizmoColor;

	public Color AttackRangeGizmoColor;

	public int Player_LearnableJobClassAbilitiesCountEachRank;

	public FP SummonMonsterCorssLevelSpawnRadius;

	public FP TriggerElementMarkCD;

	public int BuffId_Glimmer;

	[Space]
	public Material Env_VisionIndicatorMaskMaterial;

	public Material Env_NavIndicatorMaskMaterial;

	public float FX_HurtCueEffectScaleFactor;

	public Vector2 FX_HurtCueEffectScaleFactorRange;

	public Gradient FX_HurtCueEffectGradient;

	public Gradient FX_HurtCueEffectGradient_CEN;

	public float FX_HurtCueEffectExposure;

	[Min(0.01f)]
	public float FX_HurtCueEffectDuration;

	[Range(0f, 2f)]
	public float FX_HurtCueEffectStrokeWidth;

	[Range(0.01f, 2f)]
	public float FX_HurtCueEffectStrokeSmoothness;

	[Space]
	public float FX_BuffEffectAutoScaleFactor;

	public Vector2 FX_BuffEffectAutoScaleFactorRange;

	[Space]
	public float FX_TagEffectAutoScaleFactor;

	public Vector2 FX_TagEffectAutoScaleFactorRange;

	[Space]
	public Gradient FX_SuperArmorCueEffectGradient;

	public float FX_SuperArmorCueEffectExposure;

	[Min(0.01f)]
	public float FX_SuperArmorCueEffectDuration;

	[Range(0f, 1f)]
	public float FX_SuperArmorCueEffectStrokeWidth;

	[Space]
	public Gradient FX_ImmuneControlCueEffectGradient;

	public float FX_ImmuneControlCueEffectExposure;

	[Min(0.01f)]
	public float FX_ImmuneControlCueEffectDuration;

	[Range(0f, 1f)]
	public float FX_ImmuneControlCueEffectStrokeWidth;

	[Space]
	public Gradient FX_InvincibleCueEffectGradient;

	public float FX_InvincibleCueEffectExposure;

	[Min(0.01f)]
	public float FX_InvincibleCueEffectDuration;

	[Range(0f, 1f)]
	public float FX_InvincibleCueEffectStrokeWidth;

	[Space]
	public FP FX_DefaultFreezeFrameWhenDamage;

	public FP FX_DefaultFreezeFrameWhenCrit;

	public FP FX_DefaultFreezeFrameWhenToughnessBroken;

	public FP FX_DefaultFreezeFrameWhenKill;

	[TSFPRange(0f, 1f)]
	public FP FX_DefaultFreezeFrameTimeScaleWhenKill;

	[Space]
	public AdventurePlayerFeedbackEffectConfigureData FeedbackData_FinalKill;

	[Space]
	public GameObject FX_TeamUpgradeWhenBatteFinish;

	[Space]
	public string FX_VampireSurvivorSimplifyHurtFXPath;

	public int FX_VampireSurvivorSimplifyHurtFXPreloadCount;

	public float Network_DeterministicTransformSyncSmoothFactorPos;

	public float Network_DeterministicTransformSyncSmoothFactorRot;

	public string SkillTemplatePath;

	public float EnergyReduceTime;

	public int CharacterSkillAssignWeight;

	public int MeleeCharacterNormalAttackAssignWeight;

	public float AutoBattleDifferentActorSkillInterval;

	public float DynamicLoad_SceneObjLoadDistance;

	public int DynamicLoad_SceneObjFrameUpdateNum;

	public float DynamicLoad_MonsterLoadDistance;

	public int DynamicLoad_MonsterFrameUpdateNum;

	public float switchDuration;

	public float sFadeInDuration;

	public float cameraSwitchDuration;

	public FP BackOffset;

	public FP SearchRadius;

	public FP defRdin;

	public FP defRd;

	public int revivePer;

	public FP assistBornOverlapDistance;

	public FP assistBornRandomOuterRadius;

	public FP assistJumpDistance;

	public string assistInFx;

	public string assistOutFx;

	public string FX_StunFXPath;

	public string FX_StunFXPath_Weakened;

	public string FX_FrozenFXPath;

	public string FX_FrozenFXPath_Weakened;

	public string FX_FrozenFXPath_Break;

	public string FX_SleepFXPath;

	public string FX_SleepFXPath_Weakened;

	public string FX_CharmFXPath;

	public string FX_CharmFXPath_Weakened;

	public string FX_TerrorFXPath;

	public string FX_TerrorFXPath_Weakened;

	public string FX_TauntFXPath;

	public string FX_TauntFXPath_Weakened;

	public string FX_BondageFXPath;

	public string FX_BondageFXPath_Weakened;

	public string FX_SilenceFXPath;

	public string FX_SilenceFXPath_Weakened;

	public string FX_ChaosFXPath;

	public string FX_ChaosFXPath_Weakened;

	public string FX_BlindnessFXPath;

	public string FX_BlindnessFXPath_Weakened;

	public string FX_ReduceFOVFXPath;

	public DeterministicShape Shap_Chaos;

	public string normalShieldFxPath;

	public bool enableLogAndTips;

	public float logDuration;

	public int summonMaxNum;

	public int monsterMaxCount;

	public int flypyMaxNum_Player;

	public int flypyMaxNum_Monster;

	public int areaEffectMaxNum_Player;

	public int areaEffectMaxNum_Monster;

	public float RotTime;

	public float DelayTime;

	public AdventureModuleConfigureData()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 6;
			/*Error near IL_0002: Unknown opcode: 0xCB*/;
		}
	}
}
