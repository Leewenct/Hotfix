using System;
using TrueSync;

namespace AIScript.Utils;

public class SkillVariable
{
	public readonly int id;

	public FP cdMax;

	public FP cdInit;

	public FP releaseDistance;

	public FP trackTime;

	public readonly bool immBondage;

	public FP cdExpireTime;

	private Func<bool> _conditionFunc;

	public Func<bool> ConditionFunc
	{
		get
		{
			/*Error: Invalid field token*/;
		}
	}

	public SkillVariable(int id, FP cdMax, FP cdInit, FP releaseDistance, FP trackTime, bool immBondage, FP currentTime, Func<bool> conditionFunc = null)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			_ = (ushort)0;
			/*Error near IL_0004: Unknown opcode: 0xEC*/;
		}
	}

	public void SetCondition(Func<bool> conditionFunc)
	{
		throw checked((nuint)/*Error near IL_0001: Stack underflow*/);
	}

	public void ResetExpireTime(FP currentTime)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		if (/*Error near IL_0006: Stack underflow*/ > checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/))
		{
			/*Error: Invalid branch target*/;
		}
		/*Error near IL_0006: Invalid metadata token*/;
	}

	public void ClearExpireTime()
	{
		_ = 8;
		/*Error near IL_0002: Unknown opcode: 0xFD*/;
	}
}
