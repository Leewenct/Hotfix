using System.Collections.Generic;
using TrueSync;

namespace AIScript.Character._15801;

public class Config
{
	public static readonly int damageTag_AddFireMark;

	public const int buffId_FireMark = 1011;

	public static readonly int damageTag_TriggerFireMark;

	public static readonly int damageTag_FireMark;

	public const string tipsKey_TriggerFireMark = "FireMark_Trigger_Effect_02";

	public const int hitDamageId_FireMark = 158000001;

	public static readonly FP hitRadius_FireMark;

	public const string hitFxKey_FireMark = "fx_common_base_FireTag_Trigger_2";

	public const string hittedFxKey_FireMark = "";

	public static readonly FP stiffDuration_FireMark;

	public static readonly FP hitStrenth_FireMark;

	public const int skillId_NormalAttack_Default = 15810000;

	public static readonly List<string> comboTagList_NormalAttack;

	public static readonly FP holdTime_NormalAttackStage;

	public static readonly ComboInputBuffer.ActionKey[] comboKeys_Dodge;

	public static readonly FP duration_Dodge;

	public static readonly FP distance_Dodge;

	public static readonly int transitionRushSkillId;

	public static readonly ComboInputBuffer.ActionKey[] comboKeys_Rush;

	public static readonly ComboInputBuffer.ActionKey[] comboKeys_Rush_Independent;

	public static readonly ComboInputBuffer.ActionKey[] comboKeys_SpecialRushEnd;

	public const bool useSpecialRushEnd = false;

	public static readonly FP interruptTime_Rush;

	public const string comboTag_UltraSkill_Timeline = "158_Ultra_TL";

	public const string comboTag_UltraSkill_NoTimeline = "158_Ultra_NoTL";

	public const string eventName_SwitchModel_UltraSkill = "158_Change_Start";

	public static readonly FP aimRange_Transfrom;

	public static readonly FP addAttackRange_Transform;

	public const string modelGroupName_Transfrom = "toylaru";

	public const int shield_Transfrom = 15840011;

	public const int parameterId_DurationTime_Transform = 15840001;

	public const int skillId_NormalAttack_Transform = 15810001;

	public const string comboTag_NormalAttack_MainControl_Transform = "Attack_Ultra";

	public const string comboTag_NormalAttack_Support_Transform = "Attack_Ultra_Support";

	public const int skillId_Skill_Transform = 15834001;

	public const string comboTag_Skill_MainControl_Transform = "158_Skill_Ultra";

	public const string comboTag_Skill_Support_Transform = "158_Skill_Ultra_Support";

	public const int skillId_Return_Transfrom = 15834002;

	public const string comboTag_Return_Transform = "158_Ultra_End";

	public const string eventName_SwitchModel_Transform = "158_Change_End";

	public static readonly FP assistSkillRadius_Transform;

	public static readonly FP distance_ForceTrace_Summoned;

	public static readonly FP distance_StopTrace_ForPlayer_Summoned;

	public static readonly FP interval_CheckTrace_Summoned;

	public const int perkId_41 = 515841;

	public const int buffId_P41 = 15841011;

	public const string comboTag_NormalAttack_MainControl_Transform_P41 = "Attack_Ultra";

	public const string comboTag_NormalAttack_Support_Transform_P41 = "Attack_Ultra_Support";

	public const int perkId_42 = 515842;

	public static readonly int damageTag_Trigger_P42;

	public const int buffId_P42 = 15842011;

	public const int perkId_43 = 515843;

	public const int buffId_P43 = 15843011;

	public static readonly FP interval_AddBuff_P43;

	public const int buffId_D1 = 15896111;

	public const int buffId_Skill_D2 = 15896211;

	public const int buffId_Minion_D2 = 15896221;

	public const int additionalAttrId_D3 = 15896511;

	public const int buffId_D4 = 15896411;

	public const int buffId_D5 = 15896311;

	public const string logicTag_NormalAttackStage = "NormalAttackStage";

	public static readonly int eventHashCode_SummonedDeathFinish;

	unsafe static Config()
	{
		_ = *(byte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xF3*/;
	}
}
