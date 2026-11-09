using System;
using System.Collections.Generic;
using AdventureBehaviour;
using TrueSync;

namespace AIScript.Character._11701;

public class Parallel_old : ParallelBase
{
	private static readonly int attackTag_normal;

	private static readonly int attackTag_skill;

	private static readonly int attackTag_ultra;

	private static readonly int targetTag;

	private const int personalPerkId_7 = 511707;

	private readonly Dictionary<int, int> buffIdDict_perk_7;

	private const int personalPerkId_8 = 511708;

	private readonly Dictionary<int, FP> rateDict_perk_8;

	private readonly int additionalAttrId_8;

	private readonly string effectAlias_8;

	private readonly string effectAlias1_8;

	private const int personalPerkId_9 = 511709;

	private readonly Dictionary<int, int> buffIdDict_perk_9;

	private readonly Dictionary<int, int> cooldownDict_perk_9;

	private const int personalPerkId_10 = 511710;

	private readonly Dictionary<int, string> areaEffectDict_perk_10;

	private readonly FP cd_perk_10;

	private const int personalPerkId_11 = 511711;

	private readonly Dictionary<int, FP> rateDict_perk_11;

	private readonly string areaEffectAlias_perk_11;

	private const int personalPerkId_12 = 511712;

	private readonly FP hp_percent_perk_12;

	private readonly Dictionary<int, int> additionalAttrIdDict_perk_12;

	private const int personalPerkId_13 = 511713;

	private readonly Dictionary<int, int> additionalAttrIdDict_perk_13;

	private const int personalPerkId_14 = 511714;

	private readonly Dictionary<int, int> buffIdDict_perk_14;

	private const int personalPerkId_15 = 511715;

	private readonly Dictionary<int, int> buffIdDict_perk_15;

	private readonly int buffId_destiny_2;

	private readonly int buffId_destiny_6;

	private readonly string ultra_bullet_tag_destiny_6;

	private bool nextSkillEnhance;

	private PlayFX playFx;

	private PlayFX playFx1;

	private FP lastPerk9TakeEffectTime;

	private FP lastPerk10TakeEffectTime;

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

	protected unsafe virtual void OnBeforeHit(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (byte)(*unchecked((uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)));
			/*Error near IL_0003: Invalid field token*/;
		}
	}

	protected unsafe virtual void OnDamage(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (nint)(*unchecked((uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)));
			/*Error near IL_0003: Invalid field token*/;
		}
	}

	private unsafe void OnCastSkill(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected F4, but got I4
		((float[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = *(int*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0003: Invalid field token*/;
	}

	private unsafe void OnBulletFinish(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xB1*/;
	}

	public unsafe Parallel_old()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(IntPtr*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		_ = 6;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	unsafe static Parallel_old()
	{
		_ = *(byte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xEC*/;
	}
}
