using System.Collections.Generic;
using AdventureBehaviour;
using TrueSync;

namespace AIScript.Character._10701;

public class Parallel : ParallelBase
{
	public const int buff_m1 = 10796111;

	private int buff_m2;

	public const int buff_m3 = 10796311;

	private int buff_m4;

	public const int buff_m5 = 10796511;

	private readonly int atk_nomal3;

	private readonly int ultraDamageTag;

	private readonly int atk_backTag;

	private readonly int atk_skillTag;

	private readonly int atk_sp_skillTag;

	public const string fx_jiedun = "fx_10701_base_Support_CatchShield";

	private const int buff_main_id = 10793014;

	private const int buff_sp_id = 10795012;

	private readonly int parameterId_Prop_m1;

	private const string area_m1 = "AreaEffect_107_Common_HeartStone_02";

	private readonly int parameterId_cd_m1;

	public const int perk_41 = 510741;

	private const int onceHitId_41 = 10741001;

	private const int buff_xuanYuan = 10741011;

	private static readonly int perk_42;

	private const int shield_42 = 10742001;

	public static readonly int perk_43;

	public const int buff_43 = 10743011;

	public const int perk_01 = 510701;

	public const string fx_01 = "fx_10701_loop_main_skill_p01_shield_strengthen";

	public const int perk_02 = 510702;

	public const int buff_02 = 10702011;

	public static readonly FP tiliaShieldDuration;

	public static readonly FP tiliaShieldRotateSpeed;

	public const int perk_03 = 510703;

	public const int perk_04 = 510704;

	public const string area_04 = "AreaEffect_107_Main_Skill_P04_LightDefenseDown";

	public const int perk_05 = 510705;

	public const int buff_05 = 10705011;

	public const int perk_06 = 510706;

	public const string area_06 = "AreaEffect_107_Main_Skill_P06_Boom";

	public const int perk_07 = 510707;

	private const int buff_07 = 10707011;

	public const int num_07 = 12;

	public const int perk_08 = 510708;

	public const int buff_08 = 10708011;

	private const int parameterId_08 = 10708011;

	public const int perk_09 = 510709;

	public const int buff_09 = 10709011;

	public const int perk_10 = 510710;

	public const string fx_10 = "fx_10701_base_Main_Skill_P10_Revive";

	public const int buff_10 = 10710011;

	private const int perk_11 = 510711;

	private const int buff_11 = 10711011;

	private const int perk_12 = 510712;

	private static readonly FP cd_12;

	private const int buff_12 = 10712011;

	private const int perk_13 = 510713;

	private readonly FP cd_13;

	private const int parameterId_13 = 10713011;

	private const int buff_13 = 10713011;

	private const int perk_21 = 510721;

	private const string area_21 = "AreaEffect_107_Support_Skill_P21_LightTag";

	private const int perk_22 = 510722;

	private const int parameterId_time_22 = 10722011;

	private const int parameterId_cout_22 = 10722012;

	public static readonly int perk_23;

	private readonly string areaEffect_p23;

	public static readonly int perk_24;

	public const int cout_24 = 5;

	public static readonly FP forwardDis_24;

	public static readonly FP radius_out_24;

	public static readonly FP radius_in_24;

	public static readonly FP angle_24;

	private readonly int perk_25;

	private readonly string areaEffect_p25;

	private const int buff_25 = 10725011;

	private const int perk_26 = 510726;

	private const int buff_26 = 10726011;

	private readonly int perk_27;

	private const int parameterId_CD_27 = 10727012;

	private const int parameterId_27 = 10727011;

	private const int buff_27 = 10727011;

	private readonly int perk_28;

	private readonly FP cd_28;

	private const int buff_28 = 10728011;

	protected readonly int perk_29;

	private const int buff_29 = 10729011;

	protected readonly int perk_30;

	private readonly int parameterId_30;

	private readonly int parameterId_cd_30;

	protected readonly int perk_31;

	private const int buff_31 = 10731011;

	protected readonly int perk_33;

	private const int buff_33 = 10733011;

	public static int perkId_st;

	public const string area_st = "AreaEffect_107_Support_Skill_Test_AllTag";

	public static int current_cout_22;

	public static int current_cout_07;

	private long m1CD_Id;

	public static Dictionary<long, long> dicArea_p21;

	public static Dictionary<long, long> dicArea_st;

	private List<MonsterAdventureActor> _lists_p25;

	private List<MonsterAdventureActor> _lists_p25_later;

	private FP hpPercent;

	private bool iAddPerk13;

	public static bool iAdd_p10;

	private FP scriptValue_08;

	private PlayFX fxP;

	private int count_7;

	public static bool dodgeSkill;

	public static bool mainSkill;

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

	private unsafe void OnActorEnter(IEvent _evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		_ = 8;
		/*OpCode not supported: DebugBreak*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	private unsafe void OnPrefectDodge(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xFB*/;
	}

	private unsafe void OnElementMarkTrigger(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: ldarg 3 (out-of-bounds)*/;
		/*OpCode not supported: DebugBreak*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
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

	protected unsafe void OnRemoveBuff(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0003: Stack underflow*/+ *unchecked((uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
			/*OpCode not supported: DebugBreak*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
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

	protected unsafe void OnShieldHit(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	private void OnAreaFinish(IEvent evt)
	{
		//Discarded unreachable code: IL_006a, IL_00e3
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0002: Invalid metadata token*/;
	}

	public void OnUpdate()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 8;
			/*Error near IL_0002: Unknown opcode: 0xC4*/;
		}
	}

	public Parallel()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 8;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	static Parallel()
	{
		/*Error: Unknown opcode: 0xF5*/;
	}
}
