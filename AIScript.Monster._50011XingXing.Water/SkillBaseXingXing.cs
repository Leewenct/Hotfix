using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TrueSync;

namespace AIScript.Monster._50011XingXing.Water;

public class SkillBaseXingXing : SkillSimpleBase
{
	[CompilerGenerated]
	private sealed class _003CWaterArea_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillBaseXingXing _003C_003E4__this;

		private List<TSVector2> _003CtargetPos_003E5__2;

		private int _003Ci_003E5__3;

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
		public _003CWaterArea_003Ed__33(int _003C_003E1__state)
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
			//IL_00ef: Expected I4, but got Unknown
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

	protected static List<long> waterAreaFxId;

	private const string aiTypeEasy = "Easy";

	private const string aiTypeHard = "Hard";

	protected static readonly string WarningFx;

	protected static readonly int ATKLIndex;

	protected static readonly string ATKLKey;

	protected static readonly int TurnATKLIndex;

	protected static readonly string TurnATKLKey;

	protected static readonly int TurnATKRIndex;

	protected static readonly string TurnATKRKey;

	protected static readonly int ATKSIndex;

	protected static readonly string ATKSKey;

	protected static readonly int DashChargeIndex;

	protected static readonly string DashChargeJumpKey;

	protected static readonly int DashATKIndex;

	protected static readonly string DashATKJumpKey;

	protected static readonly int MoveFIndex;

	protected static readonly string MoveFKey;

	protected static readonly int MoveBIndex;

	protected static readonly string MoveBKey;

	protected static readonly int CrawlStartIndex;

	protected static readonly string CrawlStartKey;

	protected static readonly int CrawlEndIndex;

	protected static readonly string CrawlEndKey;

	protected static readonly int DropIndex;

	protected static readonly string DropAttack;

	protected static readonly int DashIndex_Attack;

	protected static readonly int ESJumpIndex;

	protected static readonly string ESJumpKey;

	protected static readonly int ESATKIndex;

	protected static readonly string ESATKKey;

	protected static readonly int jumpIndex;

	protected static readonly int earthQuakeDashIndex;

	[IteratorStateMachine(typeof(_003CWaterArea_003Ed__33))]
	protected IEnumerator WaterArea()
	{
		if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0005: ldloc 0 (out-of-bounds)*/;
		/*Error near IL_0006: Unknown opcode: 0xC1*/;
	}

	protected unsafe void TriggerArea()
	{
		//Discarded unreachable code: IL_0024
		_ = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Metadata token must be either a methoddef, memberref or methodspec*/;
	}

	protected int GetAiType()
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	protected LogicEntity GetTarget()
	{
		/*Error: Unknown opcode: 0xE9*/;
	}

	private unsafe List<TSVector2> GetAreaPos()
	{
		//IL_0003: Expected Obj, but got I4
		_ = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		LogicEntity logicEntity = (LogicEntity)0;
		/*Error near IL_0004: Unknown opcode: 0xE6*/;
	}

	public SkillBaseXingXing()
	{
		/*Error: Invalid field token*/;
	}

	unsafe static SkillBaseXingXing()
	{
		_ = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}
}
