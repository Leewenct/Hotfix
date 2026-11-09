using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AdventureBehaviour;
using TrueSync;

namespace AIScript.Monster.TowerDefense._11801;

public class SkillScript_Skill : TowerCharacterSkillBase
{
	[CompilerGenerated]
	private sealed class _003CContinueCheckTargetAlive_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillScript_Skill _003C_003E4__this;

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
		public _003CContinueCheckTargetAlive_003Ed__49(int _003C_003E1__state)
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
			//Discarded unreachable code: IL_0032, IL_00b1
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_013f: Expected I4, but got Unknown
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
			case 69:
				/*Error: Invalid branch target*/;
			case 70:
				/*Error: Invalid branch target*/;
			case 71:
				/*Error: Invalid branch target*/;
			case 72:
				/*Error: Invalid branch target*/;
			case 73:
				/*Error: Invalid branch target*/;
			case 74:
				/*Error: Invalid branch target*/;
			case 75:
				/*Error: Invalid branch target*/;
			case 76:
				/*Error: Invalid branch target*/;
			case 77:
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

	private FP searchRange;

	private static readonly string actionTag_1;

	private static readonly string actionTag_2;

	private string evt_jump1;

	private string evt_jump2;

	private FP jumpDistance;

	private FP jumpDuration;

	private static readonly int hitTag_P2;

	private static readonly int hitTag_1;

	private static readonly int hitTag_2;

	private static readonly string linkEffectAlias;

	private static readonly string linkBrokenEventName;

	private static readonly string linkBrokenEffectAlias;

	private static readonly int hitDamageId_2;

	private static readonly FP moveSpeed;

	private static readonly int moveStrength;

	private static readonly FP moveDistance;

	private const int perkId_1 = 1180101;

	private int stength_1;

	private int hitDmgId_1;

	private const int perkId_2 = 1180102;

	private static readonly string actionTag_1_perk21;

	private int count_2;

	private const int searchRange_2 = 3;

	private const int perkId_3 = 1180103;

	private int count_3;

	private static readonly string actionTag_3_perk25;

	private const int perkId_4 = 1180104;

	private static readonly int hitCount;

	private static readonly string enhanceLinkEffectAlias;

	private readonly int additionalAttrId_perk_28;

	private CoroutineNode corMain;

	private int _hitTag_1_hitCount;

	private readonly Dictionary<LogicEntity, PlayFX> _linkFxDict;

	private readonly Dictionary<LogicEntity, PlayFX> _linkFxDictP2;

	private CoroutineNode _continueCheckTargetAliveNode;

	private TSVector2 orginalPos;

	private TSVector2 targetPos;

	private LogicEntity target;

	private List<LogicEntity> entities;

	protected override void OnSkillEnable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) == 0)
		{
			/*Error: Invalid branch target*/;
		}
		if (!float.IsFinite((/*Error near IL_0008: Stack underflow*/ >> (int)/*Error near IL_0008: Stack underflow*/) ^ (ulong)checked((long)/*Error near IL_0008: ldarg 1 (out-of-bounds)*/)))
		{
			throw new ArithmeticException();
		}
		/*Error near IL_000f: Unknown opcode: 0xB2*/;
	}

	protected override void OnSkillDisable()
	{
		//Discarded unreachable code: IL_0056, IL_0105
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/>= 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = /*Error near IL_000d: Stack underflow*/+ 1685617192;
			/*Error near IL_000d: Invalid branch target*/;
		}
	}

	public void OnStart()
	{
		/*Error: Read out of bounds.*/;
	}

	private void SkillFinish()
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

	private void SkillInterrupt()
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

	private void ClearFxs()
	{
		//Discarded unreachable code: IL_0011, IL_0050
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected I4, but got Unknown
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
		}
	}

	private void DoMainLogic()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = ((byte[])checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))[8];
		/*Error near IL_0003: Invalid field token*/;
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

	protected unsafe override void OnReceiveDamage(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (nint)(*unchecked((uint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)));
			/*Error near IL_0003: Invalid field token*/;
		}
	}

	[IteratorStateMachine(typeof(_003CContinueCheckTargetAlive_003Ed__49))]
	private IEnumerator ContinueCheckTargetAlive()
	{
		if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0005: ldloc 0 (out-of-bounds)*/;
		/*Error near IL_0006: Unknown opcode: 0xBB*/;
	}

	private unsafe void OnPhase1Finish()
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		_ = ((int[])/*Error near IL_0003: Stack underflow*/)[8];
		/*Error near IL_0004: Unknown opcode: 0xE8*/;
	}

	private void OnCustom(string eventName)
	{
		//Discarded unreachable code: IL_0046, IL_0127
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ != checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Unknown opcode: 0xE2*/;
	}

	private void OnPhase2Finish()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = ((short[])checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))[8];
		/*Error near IL_0003: Invalid field token*/;
	}

	public SkillScript_Skill()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 7;
			/*Error near IL_0002: Unknown opcode: 0xCB*/;
		}
	}

	unsafe static SkillScript_Skill()
	{
		//IL_0001: Invalid comparison between Unknown and I4
		//IL_0005: Expected I4, but got I8
		if ((int)/*Error near IL_0003: Stack underflow*/ > (int)(*(byte*)(nint)/*Error near IL_0001: Stack underflow*/))
		{
			((sbyte[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/] = (sbyte)checked((long)/*Error near IL_0004: Stack underflow*/);
			((sbyte[])/*Error near IL_0006: Stack underflow*/)[/*Error near IL_0006: Stack underflow*/] = (sbyte)/*Error near IL_0006: Stack underflow*/;
			((sbyte[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (sbyte)((short[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/];
			/*Error near IL_0008: stloc 1 (out-of-bounds)*/;
			((int[])/*Error near IL_0009: ldloc 2 (out-of-bounds)*/)[-3749258747547909467L] = (int)/*Error near IL_0013: ldarg 0 (out-of-bounds)*/;
			if (/*Error near IL_0017: Stack underflow*/ <= /*Error near IL_0017: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0017: Unknown opcode: 0xC0*/;
		}
		if ((int)/*Error near IL_007d: Stack underflow*/ != 0)
		{
			*(_003F*)(nint)/*Error near IL_0051: Stack underflow*/ = /*Error near IL_0051: Stack underflow*/;
			_ = ((int[])/*Error near IL_0053: Stack underflow*/)[1];
			/*Error near IL_0054: Unknown opcode: 0xE8*/;
		}
		throw /*Error near IL_007e: Stack underflow*/;
	}
}
