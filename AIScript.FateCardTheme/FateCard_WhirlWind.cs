using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TrueSync;

namespace AIScript.FateCardTheme;

public class FateCard_WhirlWind : BaseFateCardTheme
{
	private readonly string commonWindArea;

	private readonly FP commonCenterDis;

	private readonly int hitDamageId;

	private readonly FP cd;

	private readonly string commonWindArea_Diffuse;

	private readonly int hitDamageId_2;

	private readonly string smallWindArea_Arc;

	private readonly int samllDamageId_ProB;

	private readonly int smallWindArea_count;

	private readonly int samllDamageId_ProC;

	private List<long> allWindLogicId;

	public override void OnEnable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = 0;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public override void OnDisable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	protected unsafe override void OnTrigger()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected F8, but got Obj
		if (/*Error near IL_0006: Stack underflow*/ >= checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		*(double*)(nint)/*Error near IL_000a: Stack underflow*/ = (double)System.Runtime.CompilerServices.Unsafe.Read<object>((void*)checked((sbyte)(ulong)/*Error near IL_0007: Stack underflow*/));
		/*Error near IL_000a: Unknown opcode: 0xAF*/;
	}

	private void ChooseAreaEffect(string bulletPath, LogicEntity to, bool isMove = true, int damageId = 0, FP cDis = default(FP))
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (/*Error near IL_0003: Stack underflow*/ >= /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/)
			{
				/*Error: Invalid branch target*/;
			}
			_ = (sbyte)/*Error near IL_0004: Stack underflow*/;
			/*Error near IL_0004: Unknown opcode: 0xE7*/;
		}
	}

	private unsafe void PlayHit(string areaEffect, LogicEntity to, bool isMove, bool isSuper, int damageId, bool isDiffuse, FP cDis, FP cDisMax, FP cGrowth, FP cInterval)
	{
		_ = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xCD*/;
	}

	private unsafe void PlaySmallHit(LogicEntity wind)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected Obj, but got Unknown
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0002: Stack underflow*/, (object)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)/*Error near IL_0003: Stack underflow*/, /*Error near IL_0003: Stack underflow*/);
		checked
		{
			_ = (ushort)/*Error near IL_0004: Stack underflow*/;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	private void OnAreaEffectFinish(IEvent evt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0002: Invalid metadata token*/;
	}

	public unsafe FateCard_WhirlWind()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (*(long*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/) == 0L)
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0004: Unknown opcode: 0xE6*/;
	}
}
