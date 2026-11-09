using System;
using System.Collections.Generic;

public class AdventureEffectFactory
{
	private static AdventureEffectFactory _instance;

	private static Dictionary<HotfixEnum.effectType, Type> _effectDict;

	public unsafe static AdventureEffectFactory Instance
	{
		get
		{
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Not a type handle*/;
		}
	}

	public unsafe AdventureEffectBase CreateAdventureEffect(HotfixEnum.effectType effectType)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		checked
		{
			_ = /*Error near IL_0003: Stack underflow*/+ (double)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0004: Unknown opcode: 0xE8*/;
		}
	}

	private unsafe static void initEffectDict()
	{
		_ = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		_ = 2;
		/*Error near IL_0004: Unknown opcode: 0xE6*/;
	}

	private static AdventureEffectAttribute getAttribute(Type type)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xEE*/;
		}
	}

	unsafe static AdventureEffectFactory()
	{
		_ = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		_ = 2;
		/*Error near IL_0004: Unknown opcode: 0xE6*/;
	}
}
