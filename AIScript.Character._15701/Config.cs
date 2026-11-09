using System.Collections.Generic;
using TrueSync;

namespace AIScript.Character._15701;

public class Config
{
	public static readonly int damageTag_TriggerDarkMark;

	public const int hitDamageId_DarkMark = 157000001;

	public const string hittedFx_DarkMark = "FX/ActorCommon/fx_common_base_DarkTirgger_AnZhuo";

	public const int buffId_DarkBurn = 15700001;

	public static readonly int buffTag_DarkBurn;

	public const string tipsKey_TriggerDarkMark = "DarkMark_Trigger_Effect_03";

	public const int skillId_NormalAttack = 15710000;

	public static readonly List<string> comboTagList_NormalAttack;

	public const string eventName_Shoot_NormalAttack = "157pugong";

	public const string bulletKey_NormalAttack = "Bullet_157_NrmAtk_1";

	public static readonly TSVector2 shootOffset_NormalAttack;

	public static readonly FP shootPositionY_NormalAttack;

	public static readonly ComboInputBuffer.ActionKey[] comboKeys_Dodge;

	public static readonly FP duration_Dodge;

	public static readonly FP distance_Dodge;

	public static readonly int transitionRushSkillId;

	public static readonly ComboInputBuffer.ActionKey[] comboKeys_Rush;

	public static readonly ComboInputBuffer.ActionKey[] comboKeys_Rush_Independent;

	public static readonly ComboInputBuffer.ActionKey[] comboKeys_SpecialRushEnd;

	public const bool useSpecialRushEnd = false;

	public static readonly FP interruptTime_Rush;

	public const string comboTag_UltraSkill_Timeline = "Ultra_TL";

	public const string comboTag_UltraSkill_NoTimeline = "Ultra_NoTL";

	public const string eventName_UltraSkill_BeginTrace_Support = "FollowStart";

	public const string eventName_UltraSkill_StopTrace_Support = "FollowEnd";

	public const int perkId_41 = 515741;

	public static readonly int damageTag_Trigger_P41;

	public const int additionalAttrId_P41 = 15741001;

	public const int perkId_42 = 515742;

	public const string eventName_UltraSkill_BeginShoot_P42 = "157P42PenSheStart";

	public const string eventName_UltraSkill_StopShoot_P42 = "157P42PenSheEnd";

	public const int parameterId_ShootInterval_P42 = 15742011;

	public const int parameterId_ShootCount_P42 = 15742002;

	public static readonly FP shootPositionY_P42;

	public const int randomRadius_TargetPosition_P42 = 3;

	public const string bulletKey_P42 = "Bullet_157_P42_ShuiPao";

	public const int perkId_43 = 515743;

	public const int buffId_P43 = 15743011;

	public const int buffId_D1 = 15796111;

	public const int buffId_D2 = 15796211;

	public const int buffId_D3 = 15796311;

	public const int buffId_D4 = 15796411;

	public const int additionalAttrId_D5 = 15796511;

	unsafe static Config()
	{
		_ = *(byte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xEF*/;
	}
}
