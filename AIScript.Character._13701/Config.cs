using System.Collections.Generic;
using TrueSync;

namespace AIScript.Character._13701;

public class Config
{
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

	public static readonly FP SaveComboIndexTime;

	public static readonly List<string> comboTagListNormalAttack;

	public static readonly int damageTag_NormalAttack_137;

	public const string CrossSlashTag = "Atk_Sp";

	public static readonly int CrossSlashHitTag_137;

	public const string Ultra_NoTL = "Ultra_NoTL";

	public const string Ultra_TL = "Ultra_TL";

	public const string LeftUltraAtkEvt = "Ultra_Atk_Left";

	public static readonly string[] LeftUltraAtkBullet;

	public static readonly TSVector2 LeftBulletOffset;

	public static readonly FP LeftBulletHeight;

	public const string RightUltraAtkEvt = "Ultra_Atk_Right";

	public static readonly TSVector2 RightBulletOffset;

	public static readonly FP RightBulletHeight;

	public static readonly string[] RightUltraAtkBullet;

	public static readonly FP NoTargetDistance;

	public static readonly FP UltraAtkLookAtDuration;

	public static readonly FP UltraAtkRandomRadius;

	public const int UltralAtkNum = 15;

	public static readonly int UltraHitTag_137;

	public const int ArmedEnergyBuffId = 13700012;

	public const int ArmedEnergyMax = 10;

	public static readonly FP ArmedEnergyProbability;

	public const int ArmedEnergyIncrement = 2;

	public static readonly FP ArmedEnergyCD;

	public const int buffId_WindMark = 2011;

	public const string areaEffectKey_TriggerWindMark = "AreaEffect_137_WindMark1_Bloom";

	public const string tipsKey_TriggerWindMark = "WindMark_Trigger_Effect_01";

	public static readonly int CommonTag_WindMark;

	public const int perkId_513741 = 513741;

	public const int buffId_513741_AddDamage = 13741011;

	public const int perkId_513742 = 513742;

	public const int buffId_513742_Mark = 13742011;

	public const int onceId_513742_Damage = 13742001;

	public const int perkId_513743 = 513743;

	public const int buffId_513743_AddBuff = 13743011;

	public const int buffId_D1 = 13796111;

	public const int buffId_D2 = 13796211;

	public const int buffId_D3 = 13796311;

	public const int buffId_D4 = 13796411;

	public const int additionalAttrId_D5 = 13796511;

	public const string NormalAttackCountName = "NormalAttackCount";

	public const string LastNormalAttackTimeName = "LastNormalAttackTime";

	public const string LastArmedEnergyTimeName = "LastArmedEnergyTime";

	static Config()
	{
		/*Error: Unknown opcode: 0xEC*/;
	}
}
