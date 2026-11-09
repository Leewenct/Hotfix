using System;
using System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Class)]
public class BuffEffectAttribute : Attribute
{
	public HotfixEnum.BuffEffectType BuffEffectType
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

	public BuffEffectAttribute(HotfixEnum.BuffEffectType effectType)
	{
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0002: Unknown opcode: 0xEB*/;
	}
}
