using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[Serializable]
public class FateCardThemeInfo
{
	public HotfixEnum.fateCardTheme theme;

	public HotfixEnum.fateCardThemeRank rank;

	public List<HotfixEnum.fateCardThemeTriggerType> types;

	public void LoadFrom(FateCardThemeInfo other)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and Obj
		//IL_000e: Expected I8, but got I
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_003F val = /*Error near IL_0008: Stack underflow*/+ (ulong)/*Error near IL_0007: Stack underflow*/;
			if (System.Runtime.CompilerServices.Unsafe.As<_003F, UIntPtr>(ref val) > System.Runtime.CompilerServices.Unsafe.As<FateCardThemeInfo, UIntPtr>(ref other))
			{
				/*Error: Invalid branch target*/;
			}
		}
		((long[])/*Error near IL_000e: Stack underflow*/)[/*Error near IL_000e: Stack underflow*/] = (nint)checked((nuint)unchecked((short)/*Error near IL_000c: Stack underflow*/));
		((int[])/*Error near IL_000f: Stack underflow*/)[/*Error near IL_000f: Stack underflow*/] = (int)/*Error near IL_000f: Stack underflow*/;
		/*Error near IL_000f: Unknown opcode: 0xF3*/;
	}

	public FateCardThemeInfo()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid calli metadata token*/;
		}
	}
}
