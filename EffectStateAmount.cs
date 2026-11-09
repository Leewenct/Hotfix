using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TrueSync;

[AdventureEffect(HotfixEnum.effectType.STATE_AMOUNT)]
public class EffectStateAmount : AdventureEffectBase
{
	[CompilerGenerated]
	private sealed class _003CAutoCost_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EffectStateAmount _003C_003E4__this;

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
		public _003CAutoCost_003Ed__12(int _003C_003E1__state)
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
			//IL_008b: Expected I4, but got Unknown
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

	private int leftTime;

	private int curTime;

	private FP interval;

	private HotfixEnum.stateAttributeType stateAttributeType;

	private CoroutineNode corAuto;

	private FP autoTime;

	public override void InitParams()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/<= 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (ulong)(/*Error near IL_000d: Stack underflow*/ * 1690290799);
			/*Error near IL_000e: Unknown opcode: 0x78*/;
		}
	}

	public override void AddListenerer()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		checked
		{
			if (/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/== 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (sbyte)/*Error near IL_0008: Stack underflow*/;
			/*Error near IL_0008: Invalid metadata token*/;
		}
	}

	public override void RemoveListener()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		checked
		{
			if (/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/> 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (sbyte)/*Error near IL_0008: Stack underflow*/;
			/*Error near IL_0008: Invalid metadata token*/;
		}
	}

	public override void Execute()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_003F val = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			if (false)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (ulong)(val * 1690289666);
			/*Error near IL_000e: Unknown opcode: 0xCD*/;
		}
	}

	public override void PostExecute()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		checked
		{
			if (/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/>= 0)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (int)/*Error near IL_0008: Stack underflow*/;
			/*Error near IL_0008: ldloc 24 (out-of-bounds)*/;
			/*Error near IL_000a: Unknown opcode: 0xAF*/;
		}
	}

	private void ResetAutoTime()
	{
		/*Error near IL_0001: Unknown opcode: 0xEA*/;
	}

	[IteratorStateMachine(typeof(_003CAutoCost_003Ed__12))]
	public IEnumerator AutoCost()
	{
		if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
		{
			/*Error: Invalid branch target*/;
		}
		if (/*Error near IL_0008: Stack underflow*/ > /*Error near IL_0005: ldloc 0 (out-of-bounds)*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0008: Invalid metadata token*/;
	}

	private bool Cost(HotfixEnum.stateAttributeType state)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (ulong)/*Error near IL_0007: Stack underflow*/;
			/*Error near IL_0007: Unknown opcode: 0xE2*/;
		}
	}

	private bool OnBeHitHandle(HotfixEnum.stateAttributeType stateAttr)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}

	private bool OnSpecialControlHandle(HotfixEnum.stateAttributeType stateAttr)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}

	private bool OnStrongControlHandle(HotfixEnum.stateAttributeType stateAttr)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}

	private bool OnWeekControlHandle(HotfixEnum.stateAttributeType stateAttr)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}

	private bool OnDamageHandle(HotfixEnum.stateAttributeType stateAttr)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}

	private bool OnBuffHandle(HotfixEnum.stateAttributeType stateAttr)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}

	private unsafe bool DoCost(HotfixEnum.stateAttributeType stateAttr)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		*(sbyte*)(nint)/*Error near IL_0008: Stack underflow*/ = (sbyte)checked((nuint)/*Error near IL_0007: Stack underflow*/);
		/*Error near IL_0008: ldloc 12 (out-of-bounds)*/;
		/*Error near IL_000a: Unknown opcode: 0xB1*/;
	}

	public EffectStateAmount()
	{
		/*Error: Invalid field token*/;
	}
}
