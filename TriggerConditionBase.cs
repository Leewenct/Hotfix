using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TriggerConditionBase : LogicEntity
{
	[HideInInspector]
	public GameObject triggerOwner;

	public Action triggerAction;

	protected bool isTriggered;

	protected int processValue;

	protected TriggerManager.triggerState currentSate;

	public int x
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		protected set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public int y
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		protected set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public virtual void Initialize(int x, int y)
	{
		/*Error: Unknown opcode: 0xF0*/;
	}

	public virtual void StateReset()
	{
		/*Error: Unknown opcode: 0xF0*/;
	}

	public virtual void SyncPosition()
	{
	}

	public bool CanTrigger()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected I4, but got Unknown
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

	public virtual void OnTrigger()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected F8, but got I4
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			((double[])0)[/*Error near IL_0003: ldarga 236 (out-of-bounds)*/] = 4.0;
			/*Error near IL_0007: Invalid metadata token*/;
		}
	}

	public virtual void DisableTrigger()
	{
	}

	public virtual void ToActive()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		_ = /*Error near IL_0004: Stack underflow*/>> checked((int)/*Error near IL_0003: Stack underflow*/);
		/*Error near IL_0005: ldloc 0 (out-of-bounds)*/;
		_ = ~8;
		/*Error near IL_0008: Invalid metadata token*/;
	}

	public unsafe virtual void ToDeActive()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		checked
		{
			_ = (byte)/*Error near IL_0003: Stack underflow*/;
			/*Error near IL_0006: Invalid metadata token*/;
		}
	}

	public virtual void OnPause()
	{
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0002: Unknown opcode: 0xBB*/;
	}

	public unsafe virtual void ToDestroy()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		checked
		{
			_ = (byte)/*Error near IL_0003: Stack underflow*/;
			/*Error near IL_0006: Invalid metadata token*/;
		}
	}

	public TriggerConditionBase()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0x24*/;
		}
	}
}
