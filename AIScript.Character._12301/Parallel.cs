using System.Collections.Generic;
using TrueSync;

namespace AIScript.Character._12301;

public class Parallel : ParallelBase
{
	private int buff_m1;

	private readonly int ultraAtkTag;

	private int buff_m2;

	public const int buff_m3 = 12396311;

	private int buff_m4;

	private int buff_m5;

	private static readonly int nrmAtkTag;

	private static readonly int trigger_Area_Tag;

	public const string area_123_Boom = "AreaEffect_123_FengBoom";

	public const string area_123_Boom_p2 = "AreaEffect_123_FengBoom_P2";

	private readonly FP trigger_area_cd;

	private const int trigger_property = 25;

	public const int perkId_11 = 512311;

	private readonly int addNum_11;

	public const int buff_11 = 12311011;

	public static readonly int personalPerkId_41;

	public const int shield_PerkId41 = 12354101;

	public static readonly int personalPerkId_42;

	public const string area_42 = "AreaEffect_123_Ultra_T42";

	public static readonly FP dis_p42;

	public static readonly string evt_p42;

	private const int buff_42 = 12354211;

	public static readonly int personalPerkId_43;

	public static readonly int count_p43;

	public const int parameterId_p43 = 12343001;

	public static string evt_clear;

	public static readonly int personalPerkId_21;

	private readonly int personalPerkId_22;

	private readonly FP playerCd_p22;

	private readonly int shield_p22;

	private const int buff_22 = 12352211;

	private static readonly int windEffectTag;

	public static readonly int personalPerkId_23;

	public static readonly string areaEffect_p23;

	public static readonly int personalPerkId_24;

	public static int attri_p24;

	protected readonly int personalPerkId_25;

	protected readonly int hitWindTag;

	public const int buff_p25 = 12352511;

	public static readonly int personalPerkId_26;

	public const int buff_p26 = 12352611;

	protected readonly int personalPerkId_27;

	private const int buffId_27 = 12352711;

	protected readonly int personalPerkId_28;

	public const int buff_p28 = 12352811;

	protected readonly int personalPerkId_29;

	public const int buff_p29 = 12352911;

	protected readonly int personalPerkId_30;

	public const int buff_p30 = 12353011;

	private static readonly int windEffectTag_Wave;

	protected readonly int personalPerkId_31;

	protected const int attri_p31 = 12353101;

	protected readonly int personalPerkId_32;

	protected const int buff_p32 = 12353211;

	protected readonly int personalPerkId_33;

	protected readonly int percent_p33;

	protected const int attri_p33 = 12353301;

	private readonly int perkId_09;

	private readonly FP cd_09;

	private readonly FP property_09;

	private const int buff_p9 = 12309011;

	private readonly int perkId_10;

	private readonly FP cd_10;

	private const int parameterId_10 = 12310001;

	private readonly int numMax_10;

	private int triggerAreaId;

	private Dictionary<long, FP> dicTime_p27;

	public static Dictionary<long, long> dicAreaBind_1;

	public static Dictionary<long, long> dicAreaBind_2;

	public static long summmerID;

	public static int numMax;

	private int areaCount;

	public override void OnEnable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public override void OnDisable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0004: Stack underflow*/+ ((sbyte[])checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))[0];
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	private unsafe void OnPlayerEnter(IEvent _evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		_ = 8;
		/*OpCode not supported: DebugBreak*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
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

	private unsafe void OnAreaBegin(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0x78*/;
	}

	private void OnAreaFinish(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0002: Invalid metadata token*/;
	}

	private unsafe void OnAreaEnterOrExit(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
	}

	private unsafe void OnBulletBlock(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xB2*/;
	}

	private unsafe void OnElementMarkTrigger(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: ldarg 3 (out-of-bounds)*/;
		/*OpCode not supported: DebugBreak*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	private void OnAirBorneDamageFalseEvent(IEvent evt)
	{
	}

	private void OnTriggerWindArea(IList<int> hitDamageTag, AdventureActor _monster)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	public void OnUpdate()
	{
	}

	public Parallel()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 8;
			_ = 4;
			/*Error near IL_0003: stloc 81 (out-of-bounds)*/;
			_ = 6;
			/*Error near IL_0006: Unknown opcode: 0xF0*/;
		}
	}

	unsafe static Parallel()
	{
		*(_003F*)(int)(*(byte*)(nint)/*Error near IL_0001: Stack underflow*/) = /*Error near IL_0001: ldarg 0 (out-of-bounds)*/;
		((sbyte[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/] = (sbyte)checked((byte)/*Error near IL_0004: Stack underflow*/);
		if (/*Error near IL_0007: Stack underflow*/ >= /*Error near IL_0007: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0007: Unknown opcode: 0xF0*/;
	}
}
