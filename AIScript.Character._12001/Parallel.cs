using System.Collections.Generic;
using TrueSync;

namespace AIScript.Character._12001;

public class Parallel : ParallelBase
{
	private int onceId_m1;

	private int buff_m2;

	private int buff_m3;

	private int buff_m4;

	private int onceId_m5;

	private const int buff_wind = 2011;

	private static readonly int windBoomHit;

	private readonly string windAreaEffect;

	private const string tipsKey_TriggerMark = "WindMark_Trigger_Effect_01";

	private static readonly int Skill_MainHitTag;

	private static readonly int Skill_SupportHitTag;

	private readonly string MainSkill_Bullet_Tag;

	private readonly string SupportSkill_Bullet_Tag;

	private static readonly int NormalHitTag;

	private static readonly int UltraHitTag;

	public const int buff_WindPower_Id = 12004011;

	private static readonly int windAreaTag;

	private readonly string Support_fly__Bullet_Tag;

	public const int perk_41 = 512041;

	private const int perk_42 = 512042;

	private const int buffId_42 = 12042011;

	public const int perk_43 = 512043;

	public const int buffId_43 = 12043011;

	public const int perk_01 = 512001;

	public const string bullet_01 = "Bullet_12001_B1_Skill_Garland_Mid";

	public const string bullet_01_p7 = "Bullet_12001_B1P7_Skill_Garland_BigMid";

	private const int perk_02 = 512002;

	private const int onceId_02 = 12050211;

	private readonly FP rotSpeed_02;

	private const int perk_03 = 512003;

	private const int buff_03 = 12003011;

	private const int prop_03 = 20;

	private readonly FP delay_time;

	private const int perk_04 = 512004;

	private const int num_04_01 = 5;

	private const int num_04_02 = 3;

	private const int num_max = 5;

	private const int onceId_04 = 12050411;

	private static readonly int NormalHitTag_04;

	private const int perk_05 = 512005;

	private const int buffId_05 = 12005011;

	public const int perk_06 = 512006;

	private readonly FP range_06;

	private readonly FP range_06_01;

	private const int buff_06 = 12006012;

	public const int perk_07 = 512007;

	private const int onceId_07 = 12050701;

	public const int perk_08 = 512008;

	public const int buffId_08 = 12008011;

	private const int perk_09 = 512009;

	private const int onceId_09 = 12050901;

	private const int perk_10 = 512010;

	private const int parameterId_cd_10 = 12051011;

	private const int onceId_10 = 12051001;

	private const int perk_11 = 512011;

	private const int buffId_11 = 12011011;

	private const int perk_12 = 512012;

	private const int buffId_12 = 12012011;

	private const int parameterId_12 = 12051211;

	public const int perk_13 = 512013;

	public const int buffId_13 = 12013011;

	private const int num_13 = 1;

	private readonly string bullet_normal;

	private readonly string bullet_normal_p22;

	public const int perk_21 = 512021;

	private readonly int onceId_21;

	public const string bullet_21 = "Bullet_12001_B2P21_Skill_Corolla_Strength";

	public const string bullet_21_p22 = "Bullet_12001_B2P21P22_Skill_Corolla_Strength";

	private const int perk_22 = 512022;

	private const int onceId_22 = 12052211;

	private readonly FP scale_22;

	public const int perk_23 = 512023;

	private readonly FP rotSpeed_23;

	private const int onceId_23 = 12052311;

	private static readonly int hitTag_23;

	public const int perk_24 = 512024;

	public const string event_24 = "120_B2P24";

	public const string bullet_24 = "Bullet_12001_B2P24_Wreath";

	public const string bullet_24_23 = "Bullet_12001_B2P24P23_Wreath";

	private const string area_24 = "AreaEffect_12001_B2P24_Wreath";

	private const int perk_25 = 512025;

	private const int buffId_25 = 12025011;

	private const int perk_26 = 512026;

	private const int onceId_26 = 12052601;

	private const int strengh_26 = 4;

	private readonly int perk_27;

	private const int onceId_27 = 12052701;

	private const int buffId_27 = 12027011;

	private readonly int perk_28;

	private readonly FP cd_28;

	private const int onceId_28 = 12052801;

	private readonly int perk_29;

	private const int onceId_29 = 12052901;

	private const int perk_30 = 512030;

	private const int buffId_30 = 12030011;

	private readonly int perk_31;

	private const int onceId_31 = 12053101;

	public const int perk_33 = 512033;

	public static readonly FP time_33;

	private const int buffId_33 = 12033011;

	private Dictionary<long, int> _b2t4AttackHitCount;

	private int mainWeapCount;

	private int normalHit_10;

	private int huaWeaponCount;

	public static bool normalBulletCopy;

	private int powerNum;

	public static AdventureRotateWeapon bigSupportWeapon;

	public static int bigSupWeaponRotateIndex;

	private FP pro_12;

	public static bool dodgeSkill;

	public static bool ultraSkill;

	public static bool normalSkill;

	public static bool mainSkill;

	private readonly Dictionary<FP, AdventureBullet> delayBullets;

	private readonly Dictionary<FP, TSVector2> delayBulletPos;

	private readonly Dictionary<FP, TSVector2> delayBulletDir;

	private readonly List<AdventureRotateWeapon> weapons;

	private readonly List<long> copy_buleltsID;

	private int num_28;

	private FP lastTime_06;

	private FP dis_06;

	public static List<long> monsterId_m3;

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

	private unsafe void OnCastSkill(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected F4, but got I4
		((float[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = *(int*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0003: Invalid field token*/;
	}

	protected unsafe void OnBeforeHit(IEvent evt)
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

	protected unsafe void OnElementMarkTrigger(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: ldarg 3 (out-of-bounds)*/;
		/*OpCode not supported: DebugBreak*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	protected unsafe void OnWeaponBorn(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xAB*/;
	}

	protected unsafe void OnWeaponFinish(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xAC*/;
	}

	private unsafe void OnReceiveDamageBeDeath(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0003: Invalid field token*/;
	}

	private unsafe void OnToughnessState(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Invalid metadata token*/;
	}

	private void OnWindBrust(AdventureActorReceiveDamageEvent damageEvt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected I4, but got Unknown
		switch (checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/))
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
		case 45:
			/*Error: Invalid branch target*/;
		case 46:
			/*Error: Invalid branch target*/;
		case 47:
			/*Error: Invalid branch target*/;
		case 48:
			/*Error: Invalid branch target*/;
		case 49:
			/*Error: Invalid branch target*/;
		case 50:
			/*Error: Invalid branch target*/;
		case 51:
			/*Error: Invalid branch target*/;
		case 52:
			/*Error: Invalid branch target*/;
		case 53:
			/*Error: Invalid branch target*/;
		case 54:
			/*Error: Invalid branch target*/;
		case 55:
			/*Error: Invalid branch target*/;
		case 56:
			/*Error: Invalid branch target*/;
		case 57:
			/*Error: Invalid branch target*/;
		case 58:
			/*Error: Invalid branch target*/;
		case 59:
			/*Error: Invalid branch target*/;
		case 60:
			/*Error: Invalid branch target*/;
		case 61:
			/*Error: Invalid branch target*/;
		case 62:
			/*Error: Invalid branch target*/;
		case 63:
			/*Error: Invalid branch target*/;
		case 64:
			/*Error: Invalid branch target*/;
		}
	}

	private void OnBulletInit(LogicEntity weapon)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected I4, but got Unknown
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
		}
	}

	public void OnUpdate()
	{
		//Discarded unreachable code: IL_0173
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (ulong)/*Error near IL_0007: Stack underflow*/ + 1678767215;
		}
	}

	public Parallel()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			if (8u != 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0007: Unknown opcode: 0xF0*/;
		}
	}

	unsafe static Parallel()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		*(sbyte*)(nint)/*Error near IL_0002: Stack underflow*/ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		((sbyte[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/] = (sbyte)checked((byte)unchecked(/*Error near IL_0003: Stack underflow*/ / /*Error near IL_0003: Stack underflow*/));
		if (/*Error near IL_0007: Stack underflow*/ >= /*Error near IL_0007: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0007: Unknown opcode: 0xF0*/;
	}
}
