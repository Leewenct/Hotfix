using System.Collections.Generic;
using AdventureBehaviour;
using TrueSync;

namespace AIScript.Character._11001;

public class Parallel : ParallelBase
{
	private readonly int darkBoomHit;

	private const int damageId_dark = 110000000;

	private const string darkHit_Fx = "FX/ActorCommon/fx_common_base_DarkTirgger_AnZhuo";

	private const int buff_dark = 11090000;

	private const int avatarId_A = 11000001;

	private const int avatarId_B = 11000002;

	private const int avatarId_A_Skin_1 = 11000003;

	private const int avatarId_B_Skin_1 = 11000004;

	private readonly int scriptPam_fsLeftTime;

	private readonly int scriptPam_fsmaxCount;

	private readonly int nrmalAtkTag;

	private readonly int nrmalAtk5Tag;

	private readonly int skillMainTag;

	public static readonly FP fsInnerR;

	public static readonly FP fsOutsiseR;

	private const string fx_fsBorn = "fx_11001_bullet_FenShen_BirthBullt";

	private const float fx_Speed = 10f;

	private const string tipsKey_TriggerMark = "DarkMark_Trigger_Effect_03";

	private readonly int buff_m1;

	private readonly int buff_m1_sum;

	private readonly int buff_m2;

	private readonly int buff_m2_sum;

	private readonly int buff_m3;

	private readonly int buff_m3_sum;

	private readonly int buff_m4;

	private readonly int buff_m5;

	private static readonly int ultral_atkTag;

	public const int perk_41 = 511041;

	public const string fx_41 = "fx_11001_bullet_T41_EnergyAbsorb";

	public const float fxSpeed_41 = 5f;

	public const int buff_41 = 11054111;

	private const int perk_42 = 511042;

	private const int buff_42 = 11042011;

	public const int perk_43 = 511043;

	public const int buff_43 = 11043011;

	public const int perk_01 = 511001;

	private const int perk_02 = 511002;

	private const int hitCount_02 = 6;

	private const int buff_02 = 11002011;

	private readonly FP cd_02;

	private readonly FP hit_radius;

	private readonly int hit_damageID;

	private readonly string fx_hit_02;

	public const int perk_03 = 511003;

	private static readonly FP cd_03;

	public const int scriptPam_num_03 = 11030011;

	public const int perk_04 = 511004;

	public const string area_04 = "AreaEffect_110_Main_FenShen_DieBoom";

	private const int scriptPam_num_04 = 11040011;

	private const int perk_05 = 511005;

	private const int scriptPamPro1 = 11005011;

	private const int scriptPamPro2 = 11005012;

	private const string fx_05 = "Actor/Character/11001/Fx/fx_11001_base_T5_DaoGuang";

	private const int damageID_05 = 110300003;

	private readonly int scriptPamCd_05;

	private readonly int scriptPamCount_05;

	private const int perk_06 = 511006;

	private const int buff_06 = 11050611;

	public const int perk_07 = 511007;

	public const int buff_07 = 11050711;

	private const int perk_08 = 511008;

	private const int scriptPam_num_08 = 11080011;

	private const int buff_08 = 11050811;

	private const int perk_09 = 511009;

	private const int parameterId_09 = 11050901;

	private const int buff_09 = 11050911;

	public const int perk_10 = 511010;

	private const int buff_10 = 11051011;

	private const int perk_11 = 511011;

	private const int buff_11 = 11051111;

	public const int perk_12 = 511012;

	private const int buff_12 = 11051211;

	public const int perk_13 = 511013;

	private const int add_num = 1;

	public const int buff_13 = 11051311;

	public const int perk_21 = 511021;

	public static readonly FP addTime_21;

	public const string area_21 = "Actor/Character/11001/Weapons/AreaEffect_110_Support_QuanZhang_LoopAOE";

	private const int perk_22 = 511022;

	private static readonly int leftAreaTag;

	private const string area_boom = "Actor/Character/11001/Weapons/AreaEffect_110_Support_QuanZhang_Boom";

	public const int perk_23 = 511023;

	public const int addNum_23 = 2;

	private const int scriptPam_num_23 = 11230011;

	public const int perk_24 = 511024;

	public const int addTime_24 = 5;

	private const int perk_25 = 511025;

	private const int parameterIdTriggerCount = 11052512;

	private static readonly int skillB_tag;

	private const int parameterId_25 = 11052511;

	private const int onceId_25 = 11052501;

	private const int perk_26 = 511026;

	private const int attri_26 = 11052601;

	private const int perk_27 = 511027;

	private const int buff_27 = 11052711;

	public const int perk_29 = 511029;

	public const string area_29 = "AreaEffect_110_Support_FenShen_DieBoom";

	private const int perk_31 = 511031;

	private const int buff_31 = 11053111;

	private const int perk_33 = 511033;

	private const int buff_33 = 11053311;

	public static List<LogicEntity> fsEntitys;

	private FP cd_03_Ct;

	private FP cd_11_Ct;

	public static List<long> areaLeftId;

	public static List<long> areaBoomId;

	public static FP normalComboTime;

	private CommomAreaHitConfig _areaHitConfig;

	private FP current_cd_02;

	private int triggerCount_05;

	private int triggerCount_25;

	private bool de_All;

	private int mainSkillHitCount;

	private int deCount;

	public override void OnEnable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0002: Invalid metadata token*/;
	}

	public override void OnDisable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0004: Stack underflow*/+ ((sbyte[])checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))[0];
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	private unsafe void OnAreaEffectFinish(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Invalid metadata token*/;
	}

	private unsafe void OnCastSkill(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected F4, but got I4
		((float[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = *(int*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0003: Invalid field token*/;
	}

	private unsafe void OnGetBuff(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (nuint)(*unchecked((int*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)));
			/*OpCode not supported: DebugBreak*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	private void OnElementMarkTrigger(IEvent evt)
	{
	}

	protected unsafe void OnTriggerPerfectDodge(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xFB*/;
	}

	private unsafe void OnBeforeHit(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (byte)(*unchecked((uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)));
			/*Error near IL_0003: Invalid field token*/;
		}
	}

	private unsafe void OnReceiveDamage(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (nint)(*unchecked((uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)));
			/*Error near IL_0003: Invalid field token*/;
		}
	}

	private void OnDarkHit(AdventureActor _monster, IList<int> hitDamageTag)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
		}
	}

	private unsafe void AddBuffToSumon(int buffid)
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xA8*/;
	}

	private int GetSummonid(bool isAssist)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
		default:
			/*Error: End of method reached without returning.*/;
		case 0:
			/*Error: Invalid branch target*/;
		case 1:
			/*Error: Invalid branch target*/;
		case 2:
			/*Error: Invalid branch target*/;
		case 3:
			/*Error: Invalid branch target*/;
		case 4:
			/*Error: Invalid branch target*/;
		case 5:
			/*Error: Invalid branch target*/;
		case 6:
			/*Error: Invalid branch target*/;
		case 7:
			/*Error: Invalid branch target*/;
		case 8:
			/*Error: Invalid branch target*/;
		case 9:
			/*Error: Invalid branch target*/;
		}
	}

	private unsafe void OnSummonAvatar()
	{
		_ = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		_ = -44;
		/*Error near IL_0004: Unknown opcode: 0xEA*/;
	}

	private int GetFsMaxCount()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
		default:
			/*Error: End of method reached without returning.*/;
		case 0:
			/*Error: Invalid branch target*/;
		case 1:
			/*Error: Invalid branch target*/;
		case 2:
			/*Error: Invalid branch target*/;
		case 3:
			/*Error: Invalid branch target*/;
		case 4:
			/*Error: Invalid branch target*/;
		case 5:
			/*Error: Invalid branch target*/;
		case 6:
			/*Error: Invalid branch target*/;
		case 7:
			/*Error: Invalid branch target*/;
		case 8:
			/*Error: Invalid branch target*/;
		case 9:
			/*Error: Invalid branch target*/;
		case 10:
			/*Error: Invalid branch target*/;
		case 11:
			/*Error: Invalid branch target*/;
		case 12:
			/*Error: Invalid branch target*/;
		case 13:
			/*Error: Invalid branch target*/;
		case 14:
			/*Error: Invalid branch target*/;
		case 15:
			/*Error: Invalid branch target*/;
		case 16:
			/*Error: Invalid branch target*/;
		case 17:
			/*Error: Invalid branch target*/;
		case 18:
			/*Error: Invalid branch target*/;
		case 19:
			/*Error: Invalid branch target*/;
		case 20:
			/*Error: Invalid branch target*/;
		case 21:
			/*Error: Invalid branch target*/;
		case 22:
			/*Error: Invalid branch target*/;
		case 23:
			/*Error: Invalid branch target*/;
		case 24:
			/*Error: Invalid branch target*/;
		case 25:
			/*Error: Invalid branch target*/;
		case 26:
			/*Error: Invalid branch target*/;
		case 27:
			/*Error: Invalid branch target*/;
		case 28:
			/*Error: Invalid branch target*/;
		case 29:
			/*Error: Invalid branch target*/;
		case 30:
			/*Error: Invalid branch target*/;
		case 31:
			/*Error: Invalid branch target*/;
		case 32:
			/*Error: Invalid branch target*/;
		case 33:
			/*Error: Invalid branch target*/;
		case 34:
			/*Error: Invalid branch target*/;
		case 35:
			/*Error: Invalid branch target*/;
		case 36:
			/*Error: Invalid branch target*/;
		case 37:
			/*Error: Invalid branch target*/;
		case 38:
			/*Error: Invalid branch target*/;
		case 39:
			/*Error: Invalid branch target*/;
		case 40:
			/*Error: Invalid branch target*/;
		case 41:
			/*Error: Invalid branch target*/;
		case 42:
			/*Error: Invalid branch target*/;
		case 43:
			/*Error: Invalid branch target*/;
		case 44:
			/*Error: Invalid branch target*/;
		}
	}

	public void OnUpdate()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 8;
			/*Error near IL_0002: Unknown opcode: 0xE5*/;
		}
	}

	public unsafe Parallel()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected I4, but got I8
		*(int*)(nint)/*Error near IL_0003: Stack underflow*/ = (int)(*(long*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0003: Unknown opcode: 0xFB*/;
	}

	static Parallel()
	{
		/*Error: Unknown opcode: 0xED*/;
	}
}
