using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[Serializable]
public class DiskInfo
{
	public int Id;

	public List<DiscSkillInfo> skillInfos;

	public void LoadFrom(DiskInfo other)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and Obj
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_003F val = /*Error near IL_0008: Stack underflow*/+ (ulong)/*Error near IL_0007: Stack underflow*/;
			if (System.Runtime.CompilerServices.Unsafe.As<_003F, UIntPtr>(ref val) > System.Runtime.CompilerServices.Unsafe.As<DiskInfo, UIntPtr>(ref other))
			{
				/*Error: Invalid branch target*/;
			}
			_ = (nuint)unchecked((short)/*Error near IL_000c: Stack underflow*/);
			/*Error near IL_000d: Unknown opcode: 0xAB*/;
		}
	}

	public unsafe DiskInfo()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = (ushort)(*(nuint*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}
}
