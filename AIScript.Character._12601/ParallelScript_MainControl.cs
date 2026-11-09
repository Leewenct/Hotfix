using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TrueSync;

namespace AIScript.Character._12601;

public class ParallelScript_MainControl : ParallelScript
{
	[CompilerGenerated]
	private sealed class _003CDoWaitAutoSkillB_S2_003Ed__70 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ParallelScript_MainControl _003C_003E4__this;

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
		public _003CDoWaitAutoSkillB_S2_003Ed__70(int _003C_003E1__state)
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
			//IL_005e: Expected I4, but got Unknown
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

	[CompilerGenerated]
	private sealed class _003CResetSkill_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ParallelScript_MainControl _003C_003E4__this;

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
		public _003CResetSkill_003Ed__60(int _003C_003E1__state)
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
			//IL_006c: Expected I4, but got Unknown
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

	private readonly int skillId_S1;

	private readonly int skillId_S2;

	private FP autoSkillS2WaitTime;

	private static readonly int magicHatTag;

	private static readonly int firebirdTag;

	private static readonly int fireTag;

	private readonly string magicHatBulltKey_1;

	private readonly string magicHatBulltKey_2;

	private readonly string magicHatReturnKey;

	private readonly FP catchRadius;

	private readonly string evt_Return;

	private readonly int buffId_CastSkillB;

	private readonly int prob_Passive;

	private readonly FP cd_Passive;

	protected readonly string areaEffectAttack_Passive;

	private readonly int perkId_2;

	private readonly int damage_2;

	private readonly string bullut_T1;

	private readonly string bullut_T2;

	private readonly int perkId_3;

	private readonly int buffId_3;

	private readonly int perkId_5;

	private readonly int damage_5;

	private readonly int perkId_6;

	private readonly int buffId_6;

	private readonly int perkId_7;

	private readonly int damage_7;

	private readonly int perkId_8;

	private readonly int buffId_8;

	private readonly int perkId_9;

	private readonly int buffId_9;

	private readonly int perkId_10;

	private readonly int prob_10;

	private readonly int buffId_10;

	private readonly int perkId_11;

	private readonly int buffId_11;

	private readonly int perkId_12;

	private readonly int parameterId_12;

	private readonly int buffId_12;

	private readonly int perkId_13;

	private readonly int buffId_13;

	private FP passiveCD;

	private List<LogicEntity> bulletMagicHatList;

	private List<LogicEntity> bulletMagicHatReturnList;

	private List<LogicEntity> tmpReturnList;

	private FP lastCastTime;

	private bool isInS2;

	private CoroutineNode corRebind;

	private FP resetSkillTime;

	private Dictionary<int, FP> perkCd;

	private List<long> monsterIds;

	private CoroutineNode corAutoWait;

	public override void OnEnable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = ((byte[])/*Error near IL_0004: Stack underflow*/)[((byte[])checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))[0]];
		/*Error near IL_0004: Unknown opcode: 0xED*/;
	}

	public override void OnDisable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = ((byte[])/*Error near IL_0004: Stack underflow*/)[((short[])checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))[0]];
		/*Error near IL_0004: Unknown opcode: 0xED*/;
	}

	private bool CheckCd(int perkId, FP Cd)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}

	protected override void OnCastSkill(AdventureActorCastSkillEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((nint)/*Error near IL_0009: Stack underflow*/ <= (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/))
		{
			_ = /*Error near IL_000a: Stack underflow*// /*Error near IL_000a: Stack underflow*/;
			/*Error near IL_000a: Unknown opcode: 0xBD*/;
		}
		/*Error near IL_0084: Unknown opcode: 0xC4*/;
	}

	protected override void OnCustomEvent(AdventureActorCustomEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((nint)/*Error near IL_0009: Stack underflow*/ <= (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/))
		{
			_ = ((short[])/*Error near IL_000a: Stack underflow*/)[/*Error near IL_000a: Stack underflow*/];
			/*Error near IL_000a: Unknown opcode: 0xBE*/;
		}
		checked
		{
			_ = /*Error near IL_000d: Stack underflow*/+ (/*Error near IL_000c: Stack underflow*/ >> unchecked((int)/*Error near IL_000c: Stack underflow*/));
		}
	}

	protected unsafe override void OnBattleReady(AdventureBattleReadyEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected F4, but got Unknown
		_003F val;
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			val = /*Error near IL_0008: Stack underflow*/^ (nuint)/*Error near IL_0007: Stack underflow*/;
		}
		*(float*)(nint)/*Error near IL_000a: Stack underflow*/ = (float)val;
		/*Error near IL_000a: Unknown opcode: 0xE8*/;
	}

	protected override void OnCastEndSkill(AdventureActorCastSkillEndEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		_ = (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/) >> 1424356868;
		/*Error near IL_000e: Unknown opcode: 0xF7*/;
	}

	protected override void OnRebindSkill(AdventurRebindSkill evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (nuint)/*Error near IL_0007: Stack underflow*/ + 1688160771;
		}
	}

	[IteratorStateMachine(typeof(_003CResetSkill_003Ed__60))]
	private IEnumerator ResetSkill()
	{
		if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0005: ldloc 0 (out-of-bounds)*/;
		/*Error near IL_0006: Unknown opcode: 0xCA*/;
	}

	protected override void OnBeforeHit(AdventureActorReceiveDamageBeforeHitEvent _evt)
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
		/*Error near IL_007e: Invalid metadata token*/;
	}

	protected override void OnBeforeHurt(AdventureActorReceiveDamageBeforeHitEvent _evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
	}

	protected override void OnGetBuff(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((nint)/*Error near IL_0009: Stack underflow*/ <= (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/))
		{
			_ = null;
			/*Error near IL_000a: Unknown opcode: 0xB1*/;
		}
		/*Error near IL_0014: Unknown opcode: 0xEE*/;
	}

	protected override void OnHitPre(AdventureActorReceiveDamageBeforeSettlementEvent _evt)
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
		/*Error near IL_007e: Unknown opcode: 0xF2*/;
	}

	protected override void OnBulletBorn(AdventureBulletBornEvent _evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			if (unchecked((nint)/*Error near IL_0009: Stack underflow*/ <= (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/)))
			{
				_ = (long)/*Error near IL_000a: Stack underflow*/;
				/*Error near IL_000a: Unknown opcode: 0xBD*/;
			}
			_ = /*Error near IL_0081: Stack underflow*/+ /*Error near IL_007e: ldarga 50 (out-of-bounds)*/;
			/*Error near IL_0081: Invalid branch target*/;
		}
	}

	protected override void OnBulletFinish(AdventureBulletFinishEvent _evt)
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
		/*Error near IL_007e: Unknown opcode: 0xE2*/;
	}

	protected override void OnBulletBlock(AdventureBulletBlockEvent _evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		if ((nint)/*Error near IL_0009: Stack underflow*/ > (nint)checked((nuint)/*Error near IL_0007: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0009: Unknown opcode: 0xAC*/;
	}

	protected void CreateAreaEffect(string areaName)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected I4, but got Unknown
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

	public override void OnUpdate()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = ((byte[])/*Error near IL_0004: Stack underflow*/)[((ushort[])checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))[0]];
		/*Error near IL_0004: Unknown opcode: 0xED*/;
	}

	[IteratorStateMachine(typeof(_003CDoWaitAutoSkillB_S2_003Ed__70))]
	private IEnumerator DoWaitAutoSkillB_S2()
	{
		if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0005: ldloc 0 (out-of-bounds)*/;
		/*Error near IL_0006: Unknown opcode: 0xCA*/;
	}

	public ParallelScript_MainControl()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 8;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	unsafe static ParallelScript_MainControl()
	{
		_ = *(byte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid branch target*/;
	}
}
