using System.Collections.Generic;
using TrueSync;

namespace AIScript.Character._14101;

public class Config
{
	public const string fxKey_Common = "fx_14101_loop_idle_tail";

	public const int buffId_Ink = 14191015;

	public static readonly int buffTag_Ink;

	public static readonly int damageTag_AddInk;

	public static readonly Dictionary<int, int> buffIdDic_Burn;

	public static readonly int buffTag_Burn;

	public static readonly int damageTag_TriggerBurn;

	public static readonly int damageTag_TriggerFireMark;

	public static readonly int damageTag_FireMark;

	public const string tipsKey_TriggerFireMark = "FireMark_Trigger_Effect_01";

	public const int hitDamageId_FireMark = 141000001;

	public static readonly FP hitRadius_FireMark;

	public const string hitFxPath_FireMark = "fx_14101_base_FireTag_Trigger";

	public const string hittedFxPath_FireMark = "fx_14101_hit_Fire";

	public static readonly FP stiffDuration_FireMark;

	public static readonly FP hitStrenth_FireMark;

	public static readonly List<string> comboTagList_NormalAttack;

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

	public const string comboTag_UltraSkill_Timeline = "141_Ultra_TL";

	public const string comboTag_UltraSkill_NoTimeline = "141_Ultra_NoTL";

	public const string eventName_UltraSkill_BeginLogic = "14101_Ultra_Target";

	public static readonly FP offsetDistance_UltraSkill_NoTarget;

	public static readonly FP delayTime_UltraSkill_GenerateAreaEffect;

	public const string areaEffectKey_UltraSkill = "AreaEffect_14101_Ultra_T2";

	public static readonly int areaTag_UltraSkill;

	public const int perkId_41 = 514141;

	public static readonly int damageTag_Trigger_P41;

	public const int buffId_P41 = 14141011;

	public const int perkId_42 = 514142;

	public const string areaEffectKey_UltraSkill_P42 = "AreaEffect_14101_Ultra_P42_FireWind";

	public const int perkId_43 = 514143;

	public static readonly FP delay_GenerateAreaEffect_P43;

	public const string areaEffectKey_P43 = "AreaEffect_14101_Ultra_P43_DragonBreathe";

	public const int additionalAttrId_D1 = 14196111;

	public static readonly int damageTag_Trigger_D2;

	public const int additionalAttrId_D2 = 14196211;

	public const int buffId_D3 = 14196311;

	public const int buffId_D4 = 14196411;

	public const int additionalAttrId_D5 = 14196511;

	public const string logicTag_NormalAttackStage = "NormalAttackStage";

	public static readonly int eventHashCode_UltraSkill_BeginLogic;

	unsafe static Config()
	{
		_ = *(byte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0x77*/;
	}
}
