using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[Serializable]
public class tmpThemeList
{
	public int themeId;

	public List<tempPerkInfo> perkList;

	public void LoadFrom(tmpThemeList other)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and Obj
		//IL_000f: Expected I4, but got F4
		//IL_0011: Expected I8, but got I4
		checked
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_003F val = /*Error near IL_0008: Stack underflow*/+ (ulong)/*Error near IL_0007: Stack underflow*/;
			if (System.Runtime.CompilerServices.Unsafe.As<_003F, UIntPtr>(ref val) > System.Runtime.CompilerServices.Unsafe.As<tmpThemeList, UIntPtr>(ref this))
			{
				/*Error: Invalid branch target*/;
			}
			((int[])/*Error near IL_000f: Stack underflow*/)[/*Error near IL_000f: Stack underflow*/] = unchecked((int)((float[])/*Error near IL_000e: Stack underflow*/)[(short)/*Error near IL_000c: Stack underflow*/]);
			((long[])/*Error near IL_0011: Stack underflow*/)[/*Error near IL_0011: Stack underflow*/] = (short)/*Error near IL_0010: Stack underflow*/;
			/*Error near IL_0011: Not a type handle*/;
		}
	}

	private unsafe void LoadPerkList(List<tempPerkInfo> self, List<tempPerkInfo> other)
	{
		//Discarded unreachable code: IL_000d
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
		if (!float.IsFinite(/*Error near IL_0003: Stack underflow*/))
		{
			throw new ArithmeticException();
		}
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}

	public unsafe tmpThemeList()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = *(IntPtr*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xCA*/;
	}
}
