using System;
using System.Collections.Generic;

[AdventureEffect(HotfixEnum.effectType.EFFECT_MUL)]
public class EffectMul : AdventureEffectBase
{
	private readonly List<int> effList;

	private List<int> effectUniqueIdList;

	public override void InitParams()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		checked
		{
			if (/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/<= 0)
			{
				/*Error: Invalid branch target*/;
			}
			if (!float.IsFinite((int)/*Error near IL_0008: Stack underflow*/))
			{
				throw new ArithmeticException();
			}
			_ = 2;
			/*Error near IL_000a: Unknown opcode: 0xAF*/;
		}
	}

	public override void Execute()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_003F val = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			if (false)
			{
				/*Error: Invalid branch target*/;
			}
			if (!float.IsFinite((int)val))
			{
				throw new ArithmeticException();
			}
			_ = 2;
			/*Error near IL_000a: Unknown opcode: 0xAF*/;
		}
	}

	public override void PostExecute()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		if (checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) >= 0)
		{
			/*Error: Invalid branch target*/;
		}
		((float[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (float)/*Error near IL_0008: Stack underflow*/;
		/*Error near IL_0008: stloc 2 (out-of-bounds)*/;
		if (/*Error near IL_000e: Stack underflow*/ != /*Error near IL_000e: Stack underflow*/)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_000e: Unknown opcode: 0xE5*/;
	}

	public unsafe EffectMul()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0003: Stack underflow*// (nint)(*(IntPtr*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/));
		/*Error near IL_0004: Unknown opcode: 0xEC*/;
	}
}
