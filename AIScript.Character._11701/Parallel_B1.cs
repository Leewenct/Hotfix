using System.Collections.Generic;
using TrueSync;

namespace AIScript.Character._11701;

public class Parallel_B1 : Parallel_old
{
	protected static readonly int _attackTag_additional_damage;

	protected static readonly int _targetTag;

	private const int _hitDamageId = 117000001;

	private const string _hitFxPath = "fx_13201_light_mark_harm";

	private readonly FP _additionalHitDamageCoolDown;

	private const int personalPerkId_1 = 511701;

	private readonly Dictionary<int, int> additionalAttrIdDict_perk_1;

	private const int personalPerkId_2 = 511702;

	private readonly Dictionary<int, int> cooldown_perk_2;

	private const int personalPerkId_3 = 511703;

	private readonly Dictionary<int, int> addTime_perk_3;

	private static readonly int attackTag_perk_3;

	private const int areaEffect_addTime_perk_3 = 2;

	private const int areaEffect_max_addTime_perk_3 = 5;

	private readonly Dictionary<long, FP> _additionalHitDamageTargetDic;

	private FP lastPerk2TakeEffectTime;

	private Dictionary<long, FP> areaEffectAdditionalTimeDict;

	public override void OnEnable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0x77*/;
		}
	}

	public override void OnDisable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Unknown opcode: 0x78*/;
		}
	}

	protected override void OnBeforeHit(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((nint)/*Error near IL_0009: Stack underflow*/ <= (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/))
		{
			/*Error near IL_0009: Unknown opcode: 0x77*/;
		}
		/*Error near IL_0014: Unknown opcode: 0xEE*/;
	}

	protected override void OnDamage(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((nint)/*Error near IL_0009: Stack underflow*/ <= (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/))
		{
			/*Error near IL_0009: Invalid metadata token*/;
		}
		/*Error near IL_0014: Unknown opcode: 0xEE*/;
	}

	private unsafe void OnSwitchActor(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = (byte)(*(int*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
		/*OpCode not supported: DebugBreak*/;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public Parallel_B1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 6;
			/*Error near IL_0002: Unknown opcode: 0xCB*/;
		}
	}

	unsafe static Parallel_B1()
	{
		((sbyte[])/*Error near IL_0005: Stack underflow*/)[*(byte*)(nint)/*Error near IL_0001: Stack underflow*/] = (sbyte)checked((byte)unchecked((ulong)(long)/*Error near IL_0001: ldarg 0 (out-of-bounds)*/));
		if (/*Error near IL_0007: Stack underflow*/ >= /*Error near IL_0007: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0007: Unknown opcode: 0xF0*/;
	}
}
