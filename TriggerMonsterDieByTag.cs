using System;
using System.Collections.Generic;

public class TriggerMonsterDieByTag : TriggerConditionBase
{
	public List<string> tags;

	private List<string> tagList;

	public override void ToActive()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = (ushort)0;
			/*Error near IL_0003: ldarga 236 (out-of-bounds)*/;
			/*Error near IL_0006: Invalid metadata token*/;
		}
	}

	protected unsafe override void OnDeactive()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected I8, but got I4
		*(long*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) = 0L;
		checked
		{
			_ = (ushort)/*Error near IL_0004: Stack underflow*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	private void OnMonsterDeath(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0002: Invalid metadata token*/;
	}

	public unsafe TriggerMonsterDieByTag()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (*(IntPtr*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) != (IntPtr)0)
		{
			/*Error: Invalid branch target*/;
		}
		checked
		{
			_ = (sbyte)/*Error near IL_0008: Stack underflow*/;
			/*Error near IL_0008: Metadata token must be either a methoddef, memberref or methodspec*/;
		}
	}
}
