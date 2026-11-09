using System.Collections.Generic;
using TrueSync;

namespace AIScript.Character._15601;

public class Config
{
	public static readonly int damageTag_AddLandMark;

	public const int buffId_LandMark = 6011;

	public static readonly List<string> comboTagList_NormalAttack;

	public static readonly ComboInputBuffer.ActionKey[] comboKeys_Dodge;

	public static readonly FP duration_Dodge;

	public static readonly FP distance_Dodge;

	public static readonly int transitionRushSkillId;

	public static readonly ComboInputBuffer.ActionKey[] comboKeys_Rush;

	public static readonly ComboInputBuffer.ActionKey[] comboKeys_Rush_Independent;

	public static readonly ComboInputBuffer.ActionKey[] comboKeys_SpecialRushEnd;

	public const bool useSpecialRushEnd = false;

	public static readonly FP interruptTime_Rush;

	public const string comboTag_UltraSkill_Timeline = "Ultra_TimelineOn";

	public const string comboTag_UltraSkill_NoTimeline = "Ultra_TimelineOff";

	public const string eventName_UltraSkill_Explosion = "156UltraBoom";

	public const string eventName_UltraSkill_BeginTrace_Support = "ZhuiZongStart";

	public const string eventName_UltraSkill_StopTrace_Support = "ZhuiZongEnd";

	public const int buffId_UltraSkill_Explosion = 15694011;

	public const int perkId_41 = 515641;

	public const int buffId_P41 = 15641011;

	public const int perkId_42 = 515642;

	public const string areaEffectKey__UltraSkill_Pull_P42 = "AreaEffect_156_P42_UltraXiYin";

	public const string eventName_UltraSkill_BeginPull_P42 = "XiYinStart";

	public const string eventName_UltraSkill_StopPull_P42 = "XiYinEnd";

	public const int perkId_43 = 515643;

	public static readonly int damageTag_Trigger_P43;

	public const int parameterId_P43 = 15643011;

	public const int buffId_P43 = 15643011;

	public const int buffId_D1 = 15696111;

	public static readonly int damageTag_Trigger_D2;

	public const int buffId_D2 = 15696211;

	public const int additionalAttrId_D2 = 15696211;

	public const int buffId_D3 = 15696311;

	public static readonly int damageTag_Trigger_D4;

	public const int buffId_D4 = 15696411;

	public const int buffId_D5 = 15696511;

	public const string logicTag_NormalAttackStage = "NormalAttackStage";

	unsafe static Config()
	{
		((int[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = *(ushort*)(int)(*(byte*)(nint)/*Error near IL_0001: Stack underflow*/);
		((sbyte[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/] = (sbyte)/*Error near IL_0003: ldloc 0 (out-of-bounds)*/;
		if (/*Error near IL_0007: Stack underflow*/ >= /*Error near IL_0007: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0007: Unknown opcode: 0xF0*/;
	}
}
