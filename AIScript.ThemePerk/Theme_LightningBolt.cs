using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TrueSync;

namespace AIScript.ThemePerk;

public class Theme_LightningBolt : BaseTheme
{
	[CompilerGenerated]
	private sealed class _003CDelayShoot_003Ed__87 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Theme_LightningBolt _003C_003E4__this;

		public string bullut;

		public TSVector2 startPos;

		public TSVector2 targetPos;

		public int hitDamageId;

		public int count;

		private int _003Ci_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				/*Error: Read out of bounds.*/;
			}
		}

		[DebuggerHidden]
		public _003CDelayShoot_003Ed__87(int _003C_003E1__state)
		{
			if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0002: Unknown opcode: 0xBC*/;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_011b: Expected I4, but got Unknown
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
			case 65:
				/*Error: Invalid branch target*/;
			case 66:
				/*Error: Invalid branch target*/;
			case 67:
				/*Error: Invalid branch target*/;
			case 68:
				/*Error: Invalid branch target*/;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			_ = (double)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Read out of bounds.*/;
		}
	}

	private readonly string fireBullut;

	private readonly string strongBullut;

	private readonly string fireBullut_Big;

	private readonly string strongBullut_Big;

	private static readonly int fireTag;

	private static readonly int fireTag2;

	private static readonly int bullutTag_strong;

	private static readonly int lightMaskTag;

	private readonly FP circleRadius;

	private const string triggerFxPath = "FX/Perk/fx_perk_base_light_trigger_s";

	private readonly FP delayTime;

	private Dictionary<int, int> dicDamageId;

	private readonly int perkId_0;

	private readonly FP cd_0;

	private int maxShootRC;

	private int buff_Strong;

	private readonly int perkId_1;

	private readonly FP cd_1;

	private readonly int prob_1;

	private readonly int damageId_1;

	private readonly int eff_1;

	private readonly int perkId_2;

	private readonly FP cd_2;

	private readonly int prob_2;

	private readonly int damageId_2;

	private readonly int eff_2;

	private readonly int perkId_3;

	private readonly FP cd_3;

	private readonly int prob_3;

	private readonly int damageId_3;

	private readonly int eff_3;

	private readonly int perkId_4;

	private readonly FP cd_4;

	private readonly int prob_4;

	private readonly int damageId_4;

	private readonly int eff_4;

	private readonly int perkId_6;

	private FP cd_6;

	private readonly Dictionary<int, int> dicBuff_6;

	private readonly int perkId_8;

	private FP cd_8;

	private readonly Dictionary<int, int> dicEff_8;

	private readonly int perkId_9;

	private readonly FP cd_9;

	private readonly Dictionary<int, int> dicEff_9;

	private readonly int perkId_10;

	private readonly FP cd_10;

	private readonly FP hp_10;

	private readonly Dictionary<int, int> dicEff_10;

	private const int perkId_11 = 500711;

	private readonly FP cd_11;

	private readonly int buff_11;

	private readonly Dictionary<int, int> dicProb_11;

	private const int perkId_12 = 500712;

	private int basePro_12;

	private readonly Dictionary<int, int> dicPro_12;

	private readonly Dictionary<int, int> dicEnergy_12;

	private readonly Dictionary<int, FP> dicCd_12;

	private const int perkId_13 = 500713;

	private readonly FP cd_13;

	private readonly Dictionary<int, int> dicCount_13;

	private readonly Dictionary<int, int> dicEff_13;

	private const int perkId_14 = 500714;

	private int hurtCount_14;

	private readonly FP cd_14;

	private readonly Dictionary<int, int> dicCount_14;

	private readonly Dictionary<int, int> dicEff_14;

	private AdventureTimeBomb bullutObj;

	private string tagHitCount;

	private string tagCastCount;

	private readonly Dictionary<LogicEntity, int> hitMonsterSet;

	private readonly Dictionary<LogicEntity, FP> hitMonsterDic;

	private readonly List<CoroutineNode> corList;

	private bool isInStrongState
	{
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = (nuint)unchecked((int)((byte[])checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))[0]);
				/*Error near IL_0004: Unknown opcode: 0xEC*/;
			}
		}
	}

	public override void OnEnable()
	{
		/*Error: Invalid field token*/;
	}

	public override void OnDisable()
	{
		//Discarded unreachable code: IL_0012
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (nuint)((int[])(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))[0];
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	protected override void OnPerk_NormalAtk()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected I8, but got I4
		checked
		{
			((long[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/] = 0L;
			_ = (nuint)/*Error near IL_0004: Stack underflow*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	protected override void OnPerk_Dodge()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected F4, but got I4
		checked
		{
			((float[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/] = 0f;
			_ = (nuint)/*Error near IL_0004: Stack underflow*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	protected override void OnPerk_CastSkill()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected F8, but got I4
		checked
		{
			((double[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/] = 0.0;
			_ = (nuint)/*Error near IL_0004: Stack underflow*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	protected override void OnPerk_CastAssistSkill()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected Obj, but got I4
		checked
		{
			((object[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/] = 0;
			_ = (nuint)/*Error near IL_0004: Stack underflow*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	private void CheckShoot(int perkId, int perkIndex, int prob, FP cd, int dmgId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		_ = (sbyte)checked(/*Error near IL_000d: Stack underflow*/ + ~unchecked((nuint)/*Error near IL_0008: ldarg 88 (out-of-bounds)*/));
		/*Error near IL_000e: Unknown opcode: 0xE1*/;
	}

	private void Shoot(int perkIndex, LogicEntity target, int hitDamageId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
		}
	}

	protected override void OnBeforeHit(AdventureActorReceiveDamageBeforeHitEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((nint)/*Error near IL_0009: Stack underflow*/ <= (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/))
		{
			MonsterAdventureActor monsterAdventureActor = (MonsterAdventureActor)/*Error near IL_000a: Stack underflow*/;
			/*Error near IL_000a: Unknown opcode: 0xBD*/;
		}
		/*Error near IL_007e: Unknown opcode: 0xF7*/;
	}

	protected override void OnCrit(AdventureActorReceiveCritDamageEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((nint)/*Error near IL_0009: Stack underflow*/ <= (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/))
		{
			/*Error near IL_0009: Unknown opcode: 0xE4*/;
		}
		checked
		{
			_ = /*Error near IL_008d: Stack underflow*/+ 1679337512;
		}
	}

	protected override void OnHitPre(AdventureActorReceiveDamageBeforeSettlementEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((nint)/*Error near IL_0009: Stack underflow*/ <= (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/))
		{
			/*Error near IL_000a: Unknown opcode: 0xBD*/;
		}
		((int[])/*Error near IL_007f: Stack underflow*/)[/*Error near IL_007f: Stack underflow*/] = (int)/*Error near IL_007f: Stack underflow*/;
		/*Error near IL_007f: Unknown opcode: 0xC4*/;
	}

	private string GetBullul()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) > 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	[IteratorStateMachine(typeof(_003CDelayShoot_003Ed__87))]
	private IEnumerator DelayShoot(string bullut, int hitDamageId, TSVector2 startPos, TSVector2 targetPos, int count)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	private void RefreshShootRC()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (sbyte)(ulong)/*Error near IL_0007: Stack underflow*/;
			/*Error near IL_0008: Invalid metadata token*/;
		}
	}

	private void EnterStrongState()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (nuint)unchecked((int)((byte[])checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))[0]);
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public unsafe Theme_LightningBolt()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected I4, but got I8
		*(sbyte*)(nint)/*Error near IL_0003: Stack underflow*/ = (sbyte)(*(long*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		_ = 2;
		/*Error near IL_0004: Unknown opcode: 0xE6*/;
	}

	unsafe static Theme_LightningBolt()
	{
		//IL_0001: Invalid comparison between Unknown and I4
		if ((int)/*Error near IL_0006: Stack underflow*/ < (int)(*(byte*)(nint)/*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		_ = ((byte[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/];
		/*Error near IL_0007: Unknown opcode: 0xF0*/;
	}
}
