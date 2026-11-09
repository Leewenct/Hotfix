using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class AdventureEntityGroup
{
	public string id
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		private set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public List<LogicEntity> members
	{
		[CompilerGenerated]
		get
		{
			/*Error: Invalid field token*/;
		}
		[CompilerGenerated]
		private set
		{
			throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
	}

	public bool isAlive
	{
		get
		{
			/*Error: Unknown opcode: 0xEB*/;
		}
	}

	public unsafe AdventureEntityGroup(string groupID)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(IntPtr*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xAD*/;
	}

	public bool AddMember(LogicEntity member)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/+ 0;
			/*OpCode not supported: DebugBreak*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public bool RemoveMember(LogicEntity member)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		/*Error near IL_0001: stloc 2 (out-of-bounds)*/;
		nuint num = (nuint)/*Error near IL_0003: Stack underflow*/;
		_ = ((Array)(/*Error near IL_0006: Stack underflow*/ - num)).LongLength;
		/*Error near IL_0007: Invalid branch target*/;
	}

	public bool ContainMember(LogicEntity member)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		/*Error near IL_0001: stloc 2 (out-of-bounds)*/;
		nuint num = (nuint)/*Error near IL_0003: Stack underflow*/;
		_ = ((Array)(/*Error near IL_0006: Stack underflow*/ - num)).LongLength;
		/*Error near IL_0007: Invalid branch target*/;
	}

	public LogicEntity GetMemberByDataID(int dataID)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/+ 0;
			/*OpCode not supported: DebugBreak*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public void Broadcast(IEvent evt, bool sendMyself = false)
	{
		/*Error: Unknown opcode: 0xEB*/;
	}
}
