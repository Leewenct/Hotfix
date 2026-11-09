using System;
using System.Runtime.CompilerServices;

[Serializable]
public class OutfiInfo
{
	public int Id;

	public int level;

	public int phase;

	public int star;

	public void LoadFrom(OutfiInfo other)
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
			if (System.Runtime.CompilerServices.Unsafe.As<_003F, UIntPtr>(ref val) > System.Runtime.CompilerServices.Unsafe.As<OutfiInfo, UIntPtr>(ref other))
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_000d: Not a type handle*/;
		}
	}
}
