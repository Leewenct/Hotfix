using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace AIScript.DynamicLevel;

public class TrialLevelProcess_160_Sup2 : TrialLevelProcessBase
{
	[CompilerGenerated]
	private sealed class _003CLogic_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TrialLevelProcess_160_Sup2 _003C_003E4__this;

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
		public _003CLogic_003Ed__7(int _003C_003E1__state)
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
			//IL_0043: Expected I4, but got Unknown
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

	private string waveName_taskA;

	private string waveName_taskB;

	private string waveName_taskC;

	private string waveName_taskD;

	private readonly int interactiveId_Wall;

	private readonly string teleportName;

	public override void OnLevelStart()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		_ = checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) % (nint)0;
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	[IteratorStateMachine(typeof(_003CLogic_003Ed__7))]
	private unsafe IEnumerator Logic()
	{
		if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
		{
			/*Error: Invalid branch target*/;
		}
		throw *(float*)(nint)/*Error near IL_0005: ldloc 0 (out-of-bounds)*/;
	}

	private void RefreshAllskillandFullEngergy()
	{
		/*Error: Unknown opcode: 0xEB*/;
	}

	protected override void OnRoomWaveMonsterCleared(AdventureLevelRoomWaveMonsterClearedEvent ievent)
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
			checked
			{
				_ = /*Error near IL_000d: Stack underflow*/+ (/*Error near IL_000c: Stack underflow*/ >> -68);
				return;
			}
		}
		/*Error near IL_002e: Unknown opcode: 0xE5*/;
	}

	public override void OnTaskFinish(int taskId, bool isLastTask = false)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Not a type handle*/;
	}

	public override void OnTaskTargetSuccess(int taskId, int taskTargetId, bool isLasTaskTarget = false)
	{
		checked
		{
			_ = (nuint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: Unknown opcode: 0xE1*/;
		}
	}

	public override void OnLevelEnd()
	{
		/*Error: Invalid field token*/;
	}

	public unsafe TrialLevelProcess_160_Sup2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0005: Stack underflow*/ != /*Error near IL_0003: Stack underflow*// *(long*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		_ = (double)/*Error near IL_0006: Stack underflow*/;
		/*Error near IL_0006: Unknown opcode: 0xF0*/;
	}
}
