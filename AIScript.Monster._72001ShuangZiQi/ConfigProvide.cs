using System.Runtime.CompilerServices;
using TrueSync;

namespace AIScript.Monster._72001ShuangZiQi;

public class ConfigProvide
{
	private static ConfigProvide instance;

	private int phase;

	private int lv;

	public unsafe static ConfigProvide Inst
	{
		get
		{
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
			*(_003F*)(nint)/*Error near IL_0002: Stack underflow*/ = /*Error near IL_0002: Stack underflow*/;
			System.Runtime.CompilerServices.Unsafe.Read<object>((void*)(nint)/*Error near IL_0003: Stack underflow*/);
			/*Error near IL_0004: Unknown opcode: 0xE8*/;
		}
		set
		{
			/*Error: Invalid field token*/;
		}
	}

	public unsafe int buffId_red
	{
		get
		{
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
			if (/*Error near IL_0006: Stack underflow*/ == /*Error near IL_0006: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0006: Unknown opcode: 0xF6*/;
		}
	}

	public unsafe int buffId_green
	{
		get
		{
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid branch target*/;
		}
	}

	public unsafe int buffMaxCount
	{
		get
		{
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0006: Unknown opcode: 0xF6*/;
		}
	}

	public unsafe FP interval
	{
		get
		{
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
			if (/*Error near IL_0003: Stack underflow*/ <= /*Error near IL_0003: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			/*Error near IL_0004: Unknown opcode: 0xE8*/;
		}
	}

	public void SetPhase(int phase)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}

	public void SetLv(int lv)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}
}
